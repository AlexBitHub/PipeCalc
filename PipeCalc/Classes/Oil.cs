using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalc
{
    public class Oil
    {
        float vapourPressure;
        public float Density { get; set; }
        /// <summary>
        /// Cinematic Viscosity
        /// </summary>
        public float Viscosity { get; set; }
        
        /// <summary>
        /// Put in MPa
        /// </summary>
        public float VapourPressure 
        { 
            get { return (float)(vapourPressure * Math.Pow(10, 6) / (9.81 * Density)); }
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
