using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalc
{
    public class Pump
    {
        public float a0, a1, a2 = 0, a3 = 0;
        public float c0, c1, c2 = 0, c3 = 0;
        public float CavitationParam { get; set; } = 0;

        /// <summary>
        /// For main pumps
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="a3"></param>
        /// <param name="c0"></param>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <param name="c3"></param>
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
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <param name="c0"></param>
        /// <param name="c1"></param>
        public Pump(float a0, float a1, float c0, float c1)
        {
            (this.a0, this.a1) = (a0, a1);
            (this.c0, this.c1) = (c0, c1);
        }
        
        /// <summary>
        /// Get pressure (meters) created by pump. Q - consumption in meters^3 per second.
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public float GetPressure(float Q)
        {
            Q = Q * 3600;
            float H = a0 + a1 * Q + a2 * Q * Q + a3 * Q * Q * Q;
            return H;
        }
        
        /// <summary>
        /// Get power in kiloWatt. Put consumption in meters^3 per second
        /// </summary>
        /// <param name="Q"></param>
        /// <returns></returns>
        public float GetPower(float Q)
        {
            Q = Q * 3600;
            float N = c0 + c1 * Q + c2 * Q * Q + c3 * Q * Q * Q;
            return N;
        }
        
        /// <summary>
        /// Get power in kiloWatt. Using known efficiency.
        /// </summary>
        /// <param name="Q"></param>
        /// <param name="dens"></param>
        /// <param name="effic"></param>
        /// <returns></returns>
        public float GetPower(float Q, float dens, float effic)
        {
            float N = dens * (float)9.81 * GetPressure(Q) * Q / effic;
            return N;
        }

        /// <summary>
        /// Get efficiency with formula.
        /// </summary>
        /// <param name="dens"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public float GetEfficiency(float dens, float Q)
        {
            float Effic = dens * (float)9.81 * GetPressure(Q) * Q / GetPower(Q);
            return Effic;
        }
    }
}
