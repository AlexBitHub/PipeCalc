using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalc
{
    public class Station
    {
        public string Name { get; set; }
        public float HighSpot { get; set; }
        public float Coordinate { get; set; }
        public List<Pump> Pumps { get; set; }
        public float CavitaionPressure { get; set; }
        
        public Station(string name, float highSpot, float coordinate, List<Pump> pumps)
        {
            Name = name;
            HighSpot = highSpot;
            Coordinate = coordinate;
            Pumps = pumps;
            CavitaionPressure = (from p in pumps select p.CavitationParam).Min();
        }
        public float GetDiffPresure(float Q)
        {
            return (from p in Pumps select p.GetPressure(Q)).Sum();
        }

        public float GetFullPressure(float Q)
        {
            return GetDiffPresure(Q) + HighSpot;
        }
    }
}
