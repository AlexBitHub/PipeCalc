using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PipeCalcForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserTabPageStation utpStation = new UserTabPageStation();
            utpStation.Dock = DockStyle.Fill;
            panelMainStation.Controls.Add(utpStation);
            //tabPageMainStation.Controls.Add(utpStation);
            chartGraphic.ChartAreas.Add(new ChartArea("Example function"));

            Series mySeriesPoint = new Series("Example");
            mySeriesPoint.ChartType = SeriesChartType.Line;
            mySeriesPoint.ChartArea = "Example function";
            for (double x = -Math.PI; x <= Math.PI; x += Math.PI / 10)
            {
                mySeriesPoint.Points.AddXY(x, Math.Sin(x));
            }
            chartGraphic.Series.Add(mySeriesPoint);
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

        private void tabPageMainStation_DoubleClick(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Add page of station if main page selected, else delete selected page
        /// </summary>
        private void tabCntrStations_DoubleClick(object sender, EventArgs e)
        {
            if (tabCntrStations.SelectedIndex == 0)
            {
                UserTabPageStation newUserTabStation = new UserTabPageStation();
                TabPage newTabPageStation = new TabPage($"ПНПС {tabCntrStations.TabPages.Count}");
                newTabPageStation.Controls.Add(newUserTabStation);
                tabCntrStations.TabPages.Add(newTabPageStation);
            }
            else
            {
                tabCntrStations.TabPages.Remove(tabCntrStations.SelectedTab);
            }
        }

        private void btnBorderConditions_Click(object sender, EventArgs e)
        {
            panelBorderConditions.Visible = !panelBorderConditions.Visible;
        }
    }
}
