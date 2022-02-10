using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalcLibrary.Classes
{
    public class Mark
    {
        public double Coord_mark { get; set; } // kilometer
        public double High_mark { get; set; } // meter
        public Mark(double x, double z = 0)
        {
            Coord_mark = x;
            High_mark = z;
        }
    }
}
