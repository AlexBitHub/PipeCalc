using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationPipeline;

namespace PipeCalcForm
{
    public class Presenter
    {
        private MainForm _mainForm;

        public Presenter(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void StartCalculation()
        {
            Oil oil = new Oil(_mainForm.VapourPressure, _mainForm.Density,
                                                        _mainForm.Viscosity);

        }
    }
}
