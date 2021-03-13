using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PipeCalc
{
    static class MainAlgorithms
    {
        static readonly double PI = Math.PI;
        
        /// <summary>
        /// Get number of reynolds
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="d"></param>
        /// <param name="visc"></param>
        /// <returns></returns>
        static float NumberReynolds(float Q, float d, float visc)
        {
            //var reyn = speed * d / (visc * Math.Pow(10, -4));
            var reyn = 4 * Q / (PI * d * visc * Math.Pow(10, -6));
            return (float)reyn;
        }

        /// <summary>
        /// Get coef hydro resist
        /// </summary>
        /// <param name="rough"></param>
        /// <param name="reyn"></param>
        /// <returns></returns>
        static float HydroResist(float rough, float reyn)
        {
            double resist;
            if (Math.Pow(10, 4) < reyn && reyn < 27 / Math.Pow(rough, 1.143))
                resist = (0.3164 / Math.Pow(reyn, 0.25)); //Blazius formula
            else if (reyn > 500 / rough)
                resist = (0.11 * Math.Pow(rough, 0.25)); // Shifrinson's formula
            else
                resist = (0.11 * Math.Pow((rough + 68 / reyn), 0.25)); // Altshul's formula
            return (float)resist;
        }
        /// <summary>
        /// Hydro slope (losses per 1 meter)
        /// </summary>
        /// <param name="resist"></param>
        /// <param name="Q"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        static float HydroLosses(float resist, float Q, float d)
        {
            float i = 8 * resist * (Q * Q) / (float)(Math.Pow(PI, 2) * Math.Pow(d, 5) * 9.81);
            return i;
        }

        static void IterationAlgorithm(SectorFromNPStoNPS NPS_Pipe, Oil oil, List<float> HeadArray,
                                        float speed, ref float EndPressure, out string TextMessage)
        {
            TextMessage = "";
            float Q = (float)(PI * speed * Math.Pow(NPS_Pipe.pipe.Diameter, 2) / 4);
            var Reyn = NumberReynolds(Q, NPS_Pipe.pipe.Diameter, oil.Viscosity);
            var HydroRes = HydroResist(NPS_Pipe.pipe.Roughness, Reyn);
            var HydroLoss = HydroLosses(HydroRes, Q, NPS_Pipe.pipe.Diameter) * 1000; // multiplicate to get losses per one km!

            var Head = EndPressure; // Переменная напора. Изначально равна конечно напору в ТП.
            for (int i = NPS_Pipe.X_SpotsSector.Count - 1; i > 0; i--)
            {
                Head = Head + HydroLoss * (NPS_Pipe.X_SpotsSector[i] - NPS_Pipe.X_SpotsSector[i - 1]);

                // Если начало самотечного участка
                if (Head < NPS_Pipe.Z_SpotsSector[i - 1] + oil.VapourPressure)
                    Head = NPS_Pipe.Z_SpotsSector[i - 1] + oil.VapourPressure;

                // Если напор выше максимального для трубы
                if (Head > NPS_Pipe.pipe.MaxPressure)
                    TextMessage += $"Pressure on {NPS_Pipe.X_SpotsSector[i]} kilometer is exceeded";
                HeadArray.Add(Head);
            }
            if (Head > NPS_Pipe.pipe.MaxPressure)
                TextMessage += $"Outlet pressure on station {NPS_Pipe.station.Name} is exceeded\n";
            Head = Head - NPS_Pipe.station.GetDiffPresure(Q);
            if (Head < NPS_Pipe.station.HighSpot + NPS_Pipe.station.CavitaionPressure)
                TextMessage += $"Inlet pressure on station {NPS_Pipe.station.Name} is too small";
            HeadArray.Append(Head);
            EndPressure = Head;
        }

        public static void ConvergenceIteration(LinkedSectorFromNPStoNPS ArraySectors, Oil oil, Pipeline pipe)
        {
            int counter = 0; float Speed; float delta = 10;
            float HeadCurr = 0; float HeadPrev = 0; float SpeedCurr = 0; float SpeedPrev = 0;
            

            while (Math.Abs(delta) > 0.01 && counter < 50)
            {
                if (counter == 0) Speed = (float)2.7;
                else if (counter == 1) Speed = (float)2.5;
                else Speed = SpeedPrev - (HeadPrev * (SpeedCurr - SpeedPrev) / (HeadCurr - HeadPrev));
                counter++;
                float PressureInEnd = pipe.EndPressure + pipe.EndHighSpot; // Pressure from which payment starts. ???Maybe grab values from form and put it right here???

                //float Q = (float)(PI * Speed * Math.Pow(NPS_Pipe.pipe.Diameter, 2) / 4);
                //var Reyn = NumberReynolds(Q, NPS_Pipe.pipe.Diameter, oil.Viscosity);
                //var HydroRes = HydroResist(NPS_Pipe.pipe.Roughness, Reyn);
                //var HydroLoss = HydroLosses(HydroRes, Q, NPS_Pipe.pipe.Diameter) * 1000; // multiplicate to get losses per one km!

                List<float> headArray = new List<float>();
                headArray.Add(PressureInEnd);
                foreach (var sector in ArraySectors)
                {
                    //sector.pipe.EndPressure = PressureInEnd;
                    IterationAlgorithm(sector, oil, headArray, (float)Speed, ref PressureInEnd, out string TextMess); // declare "TextMess"
                }
                delta = PressureInEnd - ArraySectors.head.Data.station.HighSpot; // How much does ZSpot of station match with last values of pressure
                (SpeedPrev, HeadPrev, SpeedCurr, HeadCurr) = (SpeedCurr, HeadCurr, Speed, delta);
            }
        }
    }
}
