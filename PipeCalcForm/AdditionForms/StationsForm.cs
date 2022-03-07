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
using PipeCalcForm.XmlClasses;

namespace PipeCalcForm.AdditionForms
{
    public partial class StationsForm : Form
    {
        public List<Station> Stations = new List<Station>();
        internal List<Pump> _pumpsFromStore;
        public StationsForm(List<Station> stations)
        {
            InitializeComponent();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(XmlPump[]));

            using (StreamReader fsB = new StreamReader("BoostPumps.xml", Encoding.GetEncoding(1251)))
            {
                _pumpsFromStore = ((XmlPump[])xmlSerializer.Deserialize(fsB)).Select(p => p.GetRealPump()).ToList();
            }
            if (stations != null)
            {
                foreach (var st in stations)
                {
                    StationPage stationPage = new StationPage(st, _pumpsFromStore);
                    tabControl1.Controls.Add(stationPage);
                }
            }
            else
            {
                StationPage mainStation = new StationPage(new Station("НПС 1", null, null), _pumpsFromStore);
                tabControl1.Controls.Add(mainStation);
            }
            
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                StationPage stationPage = new StationPage(new Station($"НПС {tabControl1.TabCount + 1}", null, null),
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
                var st = (page as StationPage).GetStation();
                if (st == null)
                    continue;
                Stations.Add(st);
            }
        }

        class StationPage : TabPage
        {
            Panel panelStation = new Panel();
            UserTabPageStation newTabStation;
            string nameStation;
            public StationPage(Station station, List<Pump> pumps) : base(station.Name)
            {
                newTabStation = new UserTabPageStation(station.Pumps, pumps);
                newTabStation.StationPosition = station.PositionStation;
                nameStation = station.Name;
                
                panelStation.Dock = DockStyle.Fill;
                newTabStation.Dock = DockStyle.Fill;
                panelStation.Controls.Add(newTabStation);
                this.Controls.Add(panelStation);
            }

            public Station GetStation()
            {
                var pumps = newTabStation.GetPumpsOfStation();
                if (pumps.Count == 0)
                    return null;
                Station st = new Station(nameStation, newTabStation.StationPosition, newTabStation.GetPumpsOfStation());
                return st;
            }
        }
    }
}
