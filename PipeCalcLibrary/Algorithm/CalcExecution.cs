using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeCalcLibrary.Classes;

namespace PipeCalcLibrary.Algorithm
{
    public class CalcExecution
    {
        Oil _oil;
        Pipeline _pipeLine;
        LinkedSectorFromNPStoNPS _stationNodes = new LinkedSectorFromNPStoNPS();
        public void CreateOil(double vapPress, double density, double visc)
        {
            _oil = new Oil(vapPress, density, visc);
        }

        public void CreatePipe(double maxPres, double length, double diam, double thick,
                        double rough, List<Mark> marks, double endHigh, double endPress)
        {
            _pipeLine = new Pipeline(maxPres, length, diam, thick,
                        rough, marks, endHigh, endPress);
        }

        public void CreateLinkedSectors(List<Station> stations)
        {
            foreach (var st in stations)
            {
                var sector = new SectorFromNPStoNPS(_pipeLine, st);
                _stationNodes.AppendFirst(sector);
            }
        }

        public List<double> StartCalculation()
        {
            return MainAlgorithms.ConvergenceIteration(_stationNodes, _oil, _pipeLine);
        }
    }
}
