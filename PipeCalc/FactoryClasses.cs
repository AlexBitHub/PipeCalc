using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalc
{
    public static class FactoryClasses
    {
        public static void CreateData()
        {
            Oil Nafta = new Oil((float)0.02, 864, 15);
            
            List<int> X_Spots = new List<int>(Enumerable.Range(0, 121)).Where(x => x % 5 == 0).ToList();
            List<int> Z_Spots = new List<int>();
            for (int i = 0; i < X_Spots.Count; i++)
            {
                Z_Spots.Add(new Random().Next(35, 55));
            }
            Pipeline PipeLine = new Pipeline(12, 120, (float)0.82, (float)0.01, (float)0.2, Z_Spots, X_Spots, 120, 40);

            Pump pump_1 = new Pump(30, (float)279.44688, (float)-0.008687, (float)0.0000011734, (float)-0.000000002225,
                                        (float)802.70329, (float)0.18507, (float)0.000183, (float)-0.000000039357);
            List<Pump> pumpsColl = new List<Pump> { pump_1, pump_1};

            Station station_1 = new Station("Main station", 120, 0, pumpsColl);
            Station station_2 = new Station("Intermediate station", 110, 60, pumpsColl);

            SectorFromNPStoNPS FirstSector = new SectorFromNPStoNPS(PipeLine, station_1);
            SectorFromNPStoNPS SecondSector = new SectorFromNPStoNPS(PipeLine, station_2);

            LinkedSectorFromNPStoNPS StationNodes = new LinkedSectorFromNPStoNPS();
            StationNodes.AppendFirst(FirstSector);
            StationNodes.AppendFirst(SecondSector);

            MainAlgorithms.ConvergenceIteration(StationNodes, Nafta, PipeLine);
        }
    }
}
