using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PipeCalcLibrary.Classes;

namespace PipeCalcForm.XmlClasses
{
    [Serializable]
    public class XmlMainSettings
    {
        public double Density { get; set; }
        public double Viscosity { get; set; }
        public double VapourPressure { get; set; }
        public double Diameter { get; set; }
        public double Length { get; set; }
        public double Thickness { get; set; }
        public double Roughness { get; set; }
        public double MaxPressure { get; set; }
        public double EndPressure { get; set; }
        public double EndHigh { get; set; }
        public List<Mark> ListMarks { get; set; }
        public List<Station> ListStations { get; set; }
        public XmlMainSettings() { }
        public XmlMainSettings(double den, double visc, double vPres, double diam, double length, double thick,
                                double rough, double maxP, double endP, double endH, List<Mark> marks, List<Station> sts)
        {
            Density = den;
            Viscosity = visc;
            VapourPressure = vPres;
            Diameter = diam;
            Length = length;
            Thickness = thick;
            Roughness = rough;
            MaxPressure = maxP;
            EndPressure = endP;
            EndHigh = endH;
            ListMarks = marks;
            ListStations = sts;
        }
    }
}
