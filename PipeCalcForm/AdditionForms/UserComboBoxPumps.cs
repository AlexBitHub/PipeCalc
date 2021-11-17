using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeCalcForm.AdditionForms
{
    public partial class UserComboBoxPumps : UserControl
    {
        public UserComboBoxPumps()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { " ", "Pump 1", "Pump 2" });

        }
    }
}
