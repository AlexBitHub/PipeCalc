using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PipeCalcLibrary.Classes
{
    [Serializable]
    public class Mark
    {
        [DisplayName("Координата")]
        public double Coord_mark { get; set; } // kilometer
        [DisplayName("Высотная отметка")]
        public double High_mark { get; set; } // meter

        public Mark(double x, double z = 0)
        {
            Coord_mark = x;
            High_mark = z;
        }

        public Mark() { }
    }
}
