using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationPipeline
{
    public class Pump
    {
        /// <summary>
        /// Coef for calculation head
        /// </summary>
        public float a0, a1, a2 = 0, a3 = 0;

        /// <summary>
        /// Coef for calculation power
        /// </summary>
        public float c0, c1, c2 = 0, c3 = 0;

        /// <summary>
        /// Cavitation reserver
        /// </summary>
        public float CavitationParam { get; set; } = 0;

        /// <summary>
        /// For main pumps
        /// </summary>
        public Pump(float CavNumber, float a0, float a1, float a2, float a3,
                                     float c0, float c1, float c2, float c3)
        {
            (this.a0, this.a1, this.a2, this.a3) = (a0, a1, a2, a3);
            (this.c0, this.c1, this.c2, this.c3) = (c0, c1, c2, c3);
            CavitationParam = CavNumber;
        }

        /// <summary>
        /// For boost pumps
        /// </summary>
        public Pump(float a0, float a1, float c0, float c1)
        {
            (this.a0, this.a1) = (a0, a1);
            (this.c0, this.c1) = (c0, c1);
        }

        /// <summary>
        /// Get pressure (meters) created by pump. Consumption (Q) is in meters^3 per second.
        /// </summary>
        public double GetPressure(float Q)
        {
            Q = Q * 3600;
            return a0 + a1 * Q + a2 * Q * Q + a3 * Q * Q * Q;
        }
        
        /// <summary>
        /// Get power in kiloWatt. Consumption (Q) is in meters^3 per second
        /// </summary>
        public double GetPower(float Q)
        {
            Q = Q * 3600;
            return c0 + c1 * Q + c2 * Q * Q + c3 * Q * Q * Q;
        }
        
        /// <summary>
        /// Get power in kiloWatt. Using known coef of efficiency.
        /// </summary>
        public double GetPower(float Q, float dens, float effic)
        {
            return dens * 9.81 * GetPressure(Q) * Q / effic;
        }

        /// <summary>
        /// Get efficiency with formula.
        /// </summary>
        public double GetEfficiency(float dens, float Q)
        {
            return dens * 9.81 * GetPressure(Q) * Q / GetPower(Q);
        }
    }
}
