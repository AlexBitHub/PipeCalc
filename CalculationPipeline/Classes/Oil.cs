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
            get { return vapourPressure * 100000 / (9.81 * Density); } // from MPa to meters
            set { vapourPressure = value; } 
        }

        public Oil(double vapourPressure, double density, double viscosity)
        {
            this.vapourPressure = vapourPressure;
            Density = density;
            Viscosity = viscosity;
        }
    }
}
