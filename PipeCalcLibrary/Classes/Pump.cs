using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalcLibrary
{
    public class Pump
    {
        public string Name { get; }
        /// <summary>
        /// Coef for calculation head
        /// </summary>
        public double a0, a1, a2 = 0, a3 = 0;

        /// <summary>
        /// Coef for calculation power
        /// </summary>
        public double c0, c1, c2 = 0, c3 = 0;

        /// <summary>
        /// Cavitation reserver
        /// </summary>
        public double CavitationParam { get; set; } = 0;

        /// <summary>
        /// For main pumps
        /// </summary>
        public Pump(double CavNumber, double a0, double a1, double a2, double a3,
                                     double c0, double c1, double c2, double c3, string name)
        {
            (this.a0, this.a1, this.a2, this.a3) = (a0, a1, a2, a3);
            (this.c0, this.c1, this.c2, this.c3) = (c0, c1, c2, c3);
            CavitationParam = CavNumber;
            Name = name;
        }

        /// <summary>
        /// For boost pumps
        /// </summary>
        public Pump(double a0, double a1, double c0, double c1, string name)
        {
            (this.a0, this.a1) = (a0, a1);
            (this.c0, this.c1) = (c0, c1);
            Name = name;
        }

        /// <summary>
        /// Get pressure (meters) created by pump. Consumption (Q) is in meters^3 per second.
        /// </summary>
        public double GetPressure(double Q)
        {
            Q = Q * 3600;
            return a0 + a1 * Q + a2 * Q * Q + a3 * Q * Q * Q;
        }
        
        /// <summary>
        /// Get power in kiloWatt. Consumption (Q) is in meters^3 per second
        /// </summary>
        public double GetPower(double Q)
        {
            Q = Q * 3600;
            return c0 + c1 * Q + c2 * Q * Q + c3 * Q * Q * Q;
        }
        
        /// <summary>
        /// Get power in kiloWatt. Using known coef of efficiency.
        /// </summary>
        public double GetPower(double Q, double dens, double effic)
        {
            return dens * 9.81 * GetPressure(Q) * Q / effic;
        }

        /// <summary>
        /// Get efficiency with formula.
        /// </summary>
        public double GetEfficiency(double dens, double Q)
        {
            return dens * 9.81 * GetPressure(Q) * Q / GetPower(Q);
        }
    }
}
