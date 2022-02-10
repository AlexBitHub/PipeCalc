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
    public partial class StationsForm : Form
    {
        public StationsForm()
        {
            InitializeComponent();
            UserTabPageStation tabPageStation = new UserTabPageStation();
            tabPageStation.Dock = DockStyle.Fill;

            this.Controls.Add(tabPageStation);
        }
    }
}
