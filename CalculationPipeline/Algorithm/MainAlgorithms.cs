using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculationPipeline
{
    static class MainAlgorithms
    {
        const double PI = Math.PI;
        
        /// <summary>
        /// Get number of reynolds
        /// </summary>
        static double NumberReynolds(double Q, double d, double visc)
        {
            //var reyn = speed * d / (visc * Math.Pow(10, -4));
            return (4 * Q / (PI * d * visc * Math.Pow(10, -6)));
        }

        /// <summary>
        /// Get coef hydro resist
        /// </summary>
        static double HydroResist(double rough, double reyn)
        {
            double resist;
            if (10000 < reyn && reyn < 27 / Math.Pow(rough, 1.143))
                resist = (0.3164 / Math.Pow(reyn, 0.25)); //Blazius formula
            else if (reyn > 500 / rough)
                resist = (0.11 * Math.Pow(rough, 0.25)); // Shifrinson's formula
            else
                resist = (0.11 * Math.Pow((rough + 68 / reyn), 0.25)); // Altshul's formula
            return resist;
        }
        /// <summary>
        /// Hydro slope (losses per 1 meter)
        /// </summary>
        static double HydroLosses(double resist, double Q, double d)
        {
            return 8 * resist * (Q * Q) / (PI * PI * Math.Pow(d, 5) * 9.81);
        }

        static void IterationAlgorithm(SectorFromNPStoNPS NPS_Pipe, Oil oil, List<double> HeadArray,
                                        double speed, ref double EndPressure, out string TextMessage)
        {
            TextMessage = "";
            double Q = (PI * speed * Math.Pow(NPS_Pipe.pipe.Diameter, 2) / 4);
            var Reyn = NumberReynolds(Q, NPS_Pipe.pipe.Diameter, oil.Viscosity);
            var HydroRes = HydroResist(NPS_Pipe.pipe.Roughness, Reyn);
            var HydroLoss = HydroLosses(HydroRes, Q, NPS_Pipe.pipe.Diameter) * 1000; // multiply by 1000 to get losses per one km!

            double Head = EndPressure; // Переменная напора. Изначально равна конечному напору в ТП.
            for (int i = NPS_Pipe.X_SpotsSector.Count - 1; i > 0; i--)
            {
                Head = Head + HydroLoss * (NPS_Pipe.X_SpotsSector[i] - NPS_Pipe.X_SpotsSector[i - 1]);

                // Если начало самотечного участка
                if (Head < NPS_Pipe.Z_SpotsSector[i - 1] + oil.VapourPressure)
                    Head = NPS_Pipe.Z_SpotsSector[i - 1] + oil.VapourPressure;

                // Если напор выше максимального для трубы
                if (Head > NPS_Pipe.pipe.MaxPressure)
                    TextMessage += $"Pressure on {NPS_Pipe.X_SpotsSector[i]} kilometer is exceeded\n";
                HeadArray.Add(Head);
            }
            if (Head > NPS_Pipe.pipe.MaxPressure)
                TextMessage += $"Outlet pressure on station {NPS_Pipe.station.Name} is exceeded\n";
            Head = Head - NPS_Pipe.station.GetDiffPresure(Q);
            if (Head < NPS_Pipe.station.HighMark + NPS_Pipe.station.CavitationPressure)
                TextMessage += $"Inlet pressure on station {NPS_Pipe.station.Name} is too small\n";
            HeadArray.Append(Head);
            EndPressure = Head;
        }

        public static void ConvergenceIteration(LinkedSectorFromNPStoNPS ArraySectors, Oil oil, Pipeline pipe)
        {
            int counter = 0; double Speed; double delta = 10;
            double HeadCurr = 0; double HeadPrev = 0; double SpeedCurr = 0; double SpeedPrev = 0;
            

            while (Math.Abs(delta) > 0.01 && counter < 50)
            {
                if (counter == 0) Speed = 2.7;
                else if (counter == 1) Speed = 2.5;
                else Speed = SpeedPrev - (HeadPrev * (SpeedCurr - SpeedPrev) / (HeadCurr - HeadPrev));
                counter++;
                double PressureInEnd = pipe.EndPressure + pipe.EndHighSpot; // Pressure from which payment starts. ???Maybe grab values from form and put it right here???

                //double Q = (double)(PI * Speed * Math.Pow(NPS_Pipe.pipe.Diameter, 2) / 4);
                //var Reyn = NumberReynolds(Q, NPS_Pipe.pipe.Diameter, oil.Viscosity);
                //var HydroRes = HydroResist(NPS_Pipe.pipe.Roughness, Reyn);
                //var HydroLoss = HydroLosses(HydroRes, Q, NPS_Pipe.pipe.Diameter) * 1000; // multiplicate to get losses per one km!

                List<double> headArray = new List<double>();
                headArray.Add(PressureInEnd);
                foreach (var sector in ArraySectors)
                {
                    //sector.pipe.EndPressure = PressureInEnd;
                    IterationAlgorithm(sector, oil, headArray, Speed, ref PressureInEnd, out string TextMess); // declare "TextMess"
                }
                delta = PressureInEnd - ArraySectors.head.Data.station.HighMark; // How much does ZSpot of station match with last values of pressure
                (SpeedPrev, HeadPrev, SpeedCurr, HeadCurr) = (SpeedCurr, HeadCurr, Speed, delta);
            }
        }
    }
}
