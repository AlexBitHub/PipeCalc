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
using System.Xml.Serialization;
using System.IO;

namespace PipeCalcForm.AdditionForms
{
    public partial class StationsForm : Form
    {
        public List<Station> stations = new List<Station>();
        private List<Pump> _pumpsFromStore;
        public StationsForm()
        {
            InitializeComponent();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(XmlPump[]));

            using (FileStream fsB = new FileStream("BoostPumps.xml", FileMode.OpenOrCreate))
            {
                _pumpsFromStore = ((XmlPump[])xmlSerializer.Deserialize(fsB)).Select(p => p.GetRealPump()).ToList();
            }
            if (stations.Count != 0)
            {
                foreach (var st in stations)
                {

                }
            }
            else
            {
                StationPage mainStation = new StationPage("МНПС", _pumpsFromStore);
                tabControl1.Controls.Add(mainStation);
            }
            
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                StationPage stationPage = new StationPage($"НПС {tabControl1.TabCount}",
                                                          _pumpsFromStore);
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
            UserTabPageStation newTabStation;
            string nameStation;
            List<Pump> selectedPumps;
            public StationPage(string textPage, List<Pump> pumps) : base(textPage)
            {
                newTabStation = new UserTabPageStation(pumps);
                newTabStation.selectedPumps = selectedPumps;
                nameStation = textPage;
                panelStation.Dock = DockStyle.Fill;
                newTabStation.Dock = DockStyle.Fill;

                panelStation.Controls.Add(newTabStation);
                this.Controls.Add(panelStation);
            }

            public Station GetStation()
            {
                Station st = new Station(nameStation, newTabStation.StationPosition, newTabStation.getPumpsOfStation());
                return st;
            }
        }
      
    }
}
