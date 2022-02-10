using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalcLibrary.Classes
{
    public class Pipeline
    {
        double maxPressure;
        public double Length { get; set; } // set in km
        public double Diameter { get; set; } // set in meters { return Diameter - 2 * Thickness; } 
        public double Thickness { get; set; } // set in meters
        public double Roughness { get; set; } // set in mm
        public double MaxPressure
        {
            get { return maxPressure * 100000 / 9810; }
            set { maxPressure = value; }
        } // set in MegaPascal

        //public List<double> HighSpots { get; set; } // set in meters
        //public List<double> XSpots { get; set; } // set in km
        public List<Mark> XZ_marks { get; set; }

        //public Dictionary<double, double> HighAndCoordSpots { get; set; }

        public double EndHighSpot { get; set; } // ?set in meters
        public double EndPressure { get; set; } // ?set in meters oil column

        public Pipeline(double maxPressure, double length, double diameter, double thickness, double roughness,
                List<Mark> marks, double endHighSpot, double endPressure)
        {
            this.maxPressure = maxPressure;
            Length = length;
            Diameter = diameter;
            Thickness = thickness;
            Roughness = roughness;
            XZ_marks = marks;
            EndHighSpot = endHighSpot;
            EndPressure = endPressure;
            //HighAndCoordSpots = xSpots.Zip(highSpots, (x, z) => new { Key = x, Value = z }).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
