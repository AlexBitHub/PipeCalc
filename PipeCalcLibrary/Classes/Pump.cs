using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalcLibrary.Classes
{
    public class Pump
    {
        public string Name { get; set; }
        List<double> _headCoef { get; set; }
        List<double> _powerCoef { get; set; }
       
        /// <summary>
        /// Cavitation reserve
        /// </summary>
        public double CavitationParam { get; set; } = 0;

        public Pump(List<double> headCoefs, List<double> powerCoefs, string name)
        {
            _headCoef = headCoefs;
            _powerCoef = powerCoefs;
            Name = name;
        }

        /// <summary>
        /// Get pressure (meters) created by pump. Consumption (Q) is in meters^3 per second.
        /// </summary>
        public double GetPressure(double Q)
        {
            Q = Q * 3600;
            double head = _headCoef[0];
            for (int i = 1; i < _headCoef.Count - 1; i++)
            {
                head = head + _headCoef[i] * Math.Pow(Q, i);
            }
            return head;
        }
        
        /// <summary>
        /// Get power in kiloWatt. Consumption (Q) is in meters^3 per second
        /// </summary>
        public double GetPower(double Q)
        {
            Q = Q * 3600;
            double power = _powerCoef[0];
            for (int i = 1; i < _powerCoef.Count - 1; i++)
            {
                power = power + _powerCoef[i] * Math.Pow(Q, i);
            }
            return power;
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
