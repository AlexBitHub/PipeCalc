using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PipeCalcLibrary.Classes;

namespace PipeCalcForm.XmlClasses
{
    [Serializable]
    public class XmlPump
    {
        public List<double> headCoef { get; set; }
        public List<double> powerCoef { get; set; }
        public string Name { get; set; }
        public double CavitationReserve { get; set; }
        public XmlPump() { }
        public XmlPump(List<double> hCoef, List<double> pCoef, string name, double cavRes = 0)
        {
            Name = name;
            headCoef = hCoef;
            powerCoef = pCoef;
            CavitationReserve = cavRes;
        }
        internal Pump GetRealPump()
        {
            return new Pump(headCoef, powerCoef, Name);
        }
    }
}
