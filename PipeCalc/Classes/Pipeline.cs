using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalc
{
    public class Pipeline
    {
        float maxPressure;
        public float Length { get; set; } // put km
        public float Diameter { get; set; } // put meters { return Diameter - 2 * Thickness; } 
        public float Thickness { get; set; } // put meters
        public float Roughness { get; set; } // put mm
        public float MaxPressure
        {
            get { return maxPressure * (float)Math.Pow(10, 6) / 9810; }
            set { maxPressure = value; }
        } // put MegaPascal
        public List<int> HighSpots { get; set; } // put meters
        public List<int> XSpots { get; set; } // put km
        public Dictionary<int, int> HighAndCoordSpots { get; set; }

        public float EndHighSpot { get; set; } // ?put meters
        public float EndPressure { get; set; } // ?put meters oil column

        public Pipeline(float maxPressure, float length, float diameter, float thickness, float roughness,
                List<int> highSpots, List<int> xSpots, float endHighSpot, float endPressure)
        {
            this.maxPressure = maxPressure;
            Length = length;
            Diameter = diameter;
            Thickness = thickness;
            Roughness = roughness;
            HighSpots = highSpots;
            XSpots = xSpots;
            EndHighSpot = endHighSpot;
            EndPressure = endPressure;
            HighAndCoordSpots = xSpots.Zip(highSpots, (x, z) => new { Key = x, Value = z }).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
