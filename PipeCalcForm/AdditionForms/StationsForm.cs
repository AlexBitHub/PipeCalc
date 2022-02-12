using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PipeCalcLibrary.Classes;

namespace PipeCalcForm.AdditionForms
{
    public partial class StationsForm : Form
    {
        public List<Station> stations = new List<Station>();
        public StationsForm()
        {
            InitializeComponent();
            UserTabPageStation tabPageStation = new UserTabPageStation();
            tabPageStation.Dock = DockStyle.Fill;
            panelMainSt.Controls.Add(tabPageStation);
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                StationPage stationPage = new StationPage($"НПС {tabControl1.TabCount}");
                tabControl1.Controls.Add(stationPage);
            }
            else
                tabControl1.Controls.Remove(tabControl1.SelectedTab);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (TabPage page in tabControl1.TabPages)
            {
                (page as StationPage).GetStation();
            }
        }

        class StationPage : TabPage
        {
            Panel panelStation = new Panel();
            UserTabPageStation newTabStation = new UserTabPageStation();
            string nameStation;
            public StationPage(string textPage) : base(textPage)
            {
                nameStation = textPage;
                panelStation.Dock = DockStyle.Fill;
                newTabStation.Dock = DockStyle.Fill;

                panelStation.Controls.Add(newTabStation);
                this.Controls.Add(panelStation);
            }

            public Station GetStation()
            {
                Station st = new Station(nameStation, newTabStation.StationPosition, newTabStation.pumpsOfStation());
                return st;
            }
        }
    }
}
