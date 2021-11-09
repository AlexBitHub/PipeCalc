using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPipeline
{
    public class Pipeline
    {
        double maxPressure;
        public float Length { get; set; } // set in km
        public float Diameter { get; set; } // set in meters { return Diameter - 2 * Thickness; } 
        public float Thickness { get; set; } // set in meters
        public float Roughness { get; set; } // set in mm
        public double MaxPressure
        {
            get { return maxPressure * Math.Pow(10, 6) / 9810; }
            set { maxPressure = value; }
        } // set in MegaPascal
        public List<float> HighSpots { get; set; } // set in meters
        public List<float> XSpots { get; set; } // set in km
        public Dictionary<float, float> HighAndCoordSpots { get; set; }

        public float EndHighSpot { get; set; } // ?set in meters
        public float EndPressure { get; set; } // ?set in meters oil column

        public Pipeline(float maxPressure, float length, float diameter, float thickness, float roughness,
                List<float> highSpots, List<float> xSpots, float endHighSpot, float endPressure)
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
