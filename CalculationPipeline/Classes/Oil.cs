using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPipeline
{
    public class Oil
    {
        double vapourPressure;
        public double Density { get; set; }
        /// <summary>
        /// Cinematic Viscosity
        /// </summary>
        public double Viscosity { get; set; }
        
        /// <summary>
        /// Put in MPa
        /// </summary>
        public double VapourPressure 
        { 
            get { return vapourPressure * Math.Pow(10, 6) / (9.81 * Density); } // from MPa to meters
            set { vapourPressure = value; } 
        }

        public Oil(float vapourPressure, float density, float viscosity)
        {
            this.vapourPressure = vapourPressure;
            Density = density;
            Viscosity = viscosity;
        }
    }
}
