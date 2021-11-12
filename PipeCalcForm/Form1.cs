using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeCalcForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void hidingSubPanelProperties()
        {
            panelOilProperties.Visible = false;
            panelPipeProperties.Visible = false;
        }

        private void btnOilProperties_Click(object sender, EventArgs e)
        {
            panelOilProperties.Visible = !panelOilProperties.Visible;
        }

        private void btnPipeProperties_Click(object sender, EventArgs e)
        {
            panelPipeProperties.Visible = !panelPipeProperties.Visible;
        }

        private void btnStationProperties_Click(object sender, EventArgs e)
        {
            panelStationProperties.Visible = !panelStationProperties.Visible;
        }
    }
}
