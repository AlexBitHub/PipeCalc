using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPipeline
{
    public class Station
    {
        public string Name { get; set; }

        /// <summary>
        /// High mark of station (meters)
        /// </summary>
        public float HighMark { get; set; }

        /// <summary>
        /// Coordinate of station (km)
        /// </summary>
        public float Coordinate { get; set; }

        /// <summary>
        /// All pumps at the station
        /// </summary>
        public List<Pump> Pumps { get; set; }

        /// <summary>
        /// Minimal station inlet pressure
        /// </summary>
        public float CavitationPressure { get; set; }
        
        public Station(string name, float highSpot, float coordinate, List<Pump> pumps)
        {
            Name = name;
            HighMark = highSpot;
            Coordinate = coordinate;
            Pumps = pumps;
            CavitationPressure = (from p in pumps select p.CavitationParam).Min(); //cavitation pressure is minimal cavitaion reserve all pumps
        }

        /// <summary>
        /// Get pressure excluding high mark
        /// </summary>
        public double GetDiffPresure(float Q)
        {
            return (from p in Pumps select p.GetPressure(Q)).Sum();
        }

        /// <summary>
        /// Get pressure considering high mark
        /// </summary>
        public double GetFullPressure(float Q)
        {
            return GetDiffPresure(Q) + HighMark;
        }
    }
}
