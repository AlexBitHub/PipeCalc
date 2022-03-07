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
using PipeCalcLibrary.Classes;
using PipeCalcLibrary.Algorithm;
using PipeCalcForm.AdditionForms;
using PipeCalcForm.XmlClasses;
using System.Xml.Serialization;
using System.IO;

namespace PipeCalcForm
{
    public partial class MainForm : Form
    {
        #region Properties

        public double Density
        {
            get { return double.Parse(txtBoxDens.Text); }
        }
        public double Viscosity
        {
            get { return double.Parse(txtBoxViscos.Text); }
        }
        public double VapourPressure
        {
            get { return double.Parse(txtBoxVapourPres.Text); }
        }

        public double Diameter
        {
            get { return double.Parse(txtBoxDiameter.Text); }
        }
        public double LengthPipeline
        {
            get 
            {
                if (string.IsNullOrEmpty(txtBoxLength.Text))
                    return 0;
                return double.Parse(txtBoxLength.Text); 
            }
        }
        public double Thickness
        {
            get { return double.Parse(txtBoxThickness.Text); }
        }
        public double Roughness
        {
            get { return double.Parse(txtBoxRoughness.Text); }
        }

        public double EndPressure
        {
            get { return double.Parse(txtBoxEndPressure.Text); }
        }
        public double EndHighMark
        {
            get
            {
                if (string.IsNullOrEmpty(txtBoxEndHigh.Text))
                    return 0;
                return double.Parse(txtBoxEndHigh.Text);
            }
        }

        public double MaxPressure
        {
            get
            {
                if (string.IsNullOrEmpty(txtBoxMaxPressure.Text))
                    return 0;
                return double.Parse(txtBoxMaxPressure.Text);
            }
        }

        #endregion
        public List<Mark> ZXMarks { get; set; }
        public List<Station> Stations { get; set; }
       

        #region Handlers events of buttons on panel

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
        private void btnBorderConditions_Click(object sender, EventArgs e)
        {
            panelBorderConditions.Visible = !panelBorderConditions.Visible;
        }
        private void btnPipelineProfile_Click(object sender, EventArgs e)
        {
            panelPipelineProfile.Visible = !panelPipelineProfile.Visible;
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();

            try
            {
                LoadSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }          

        private void playCalculation(object sender, EventArgs e)
        {
            CalcExecution calcExecution = new CalcExecution();
            calcExecution.CreateOil(VapourPressure, Density, Viscosity);
            calcExecution.CreatePipe(MaxPressure, LengthPipeline, Diameter,
                                     Thickness, Roughness, ZXMarks, EndHighMark, EndPressure);
            calcExecution.CreateLinkedSectors(Stations);
            var pressureList = calcExecution.StartCalculation();
            BuildGraph(pressureList);
           
        }

        private void BuildGraph(List<double> presure)
        {
            chartGraphic.ChartAreas.Clear();
            chartGraphic.ChartAreas.Add(new ChartArea("Hydro slop"));
            Series series1 = new Series("Профиль трубопровода");
            series1.ChartType = SeriesChartType.Line;
            series1.Color = Color.SeaGreen;
            series1.ChartArea = "Hydro slop";

            for (int i = 0; i < ZXMarks.Count; i++)
            {
                series1.Points.AddXY(ZXMarks[i].Coord_mark, ZXMarks[i].High_mark);
            }
            chartGraphic.Series.Add(series1);
            Series series2 = new Series("Гидравлический уклон");
            series2.ChartType = SeriesChartType.Line;
            series2.Color = Color.Brown;
            series2.ChartArea = "Hydro slop";
            for (int i = 0; i < ZXMarks.Count; i++)
            {
                series2.Points.AddXY(ZXMarks[i].Coord_mark, presure[ZXMarks.Count - i - 1]);
            }
            chartGraphic.Series.Add(series2);
        }

        private void buttonSetStations_Click(object sender, EventArgs e)
        {
            if (Stations.Count == 0) Stations = null;
            StationsForm statForm = new StationsForm(Stations);
            if (statForm.ShowDialog(this) == DialogResult.OK)
            {
                Stations = statForm.Stations;
            }
        }

        private void btnSetMarks_Click(object sender, EventArgs e)
        {
            CoordinateAndHighMarkForm coordinateAndHighMarkForm = new CoordinateAndHighMarkForm(LengthPipeline, EndHighMark);
            if (ZXMarks.Count == 0)
                ZXMarks = null;
            coordinateAndHighMarkForm.marksList = ZXMarks;
            if (coordinateAndHighMarkForm.ShowDialog(this) == DialogResult.OK)
            {
                ZXMarks = coordinateAndHighMarkForm.marksList;
            }
        }

        private void LoadSettings()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(XmlMainSettings));
            using (FileStream fs = new FileStream("MainSettings.xml", FileMode.OpenOrCreate))
            {
                XmlMainSettings XmlMainSettings = (XmlMainSettings)xmlSer.Deserialize(fs);
                txtBoxDens.Text = XmlMainSettings.Density.ToString();
                txtBoxViscos.Text = XmlMainSettings.Viscosity.ToString();
                txtBoxVapourPres.Text = XmlMainSettings.VapourPressure.ToString();
                txtBoxDiameter.Text = XmlMainSettings.Diameter.ToString();
                txtBoxLength.Text = XmlMainSettings.Length.ToString();
                txtBoxThickness.Text = XmlMainSettings.Thickness.ToString();
                txtBoxRoughness.Text = XmlMainSettings.Roughness.ToString();
                txtBoxMaxPressure.Text = XmlMainSettings.MaxPressure.ToString();
                txtBoxEndPressure.Text = XmlMainSettings.EndPressure.ToString();
                txtBoxEndHigh.Text = XmlMainSettings.EndHigh.ToString();
                ZXMarks = XmlMainSettings.ListMarks;
                Stations = XmlMainSettings.ListStations;
            }
        }

        private void SaveSettings()
        {
            XmlSerializer xmlSer = new XmlSerializer(typeof(XmlMainSettings));
            using (FileStream fs = new FileStream("MainSettings.xml", FileMode.Truncate))
            {
                XmlMainSettings xms = new XmlMainSettings(Density, Viscosity, VapourPressure, Diameter,
                                        LengthPipeline, Thickness, Roughness, MaxPressure, EndPressure,
                                        EndHighMark, ZXMarks, Stations);
                xmlSer.Serialize(fs, xms);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Настройки сохранены");            
        }
    }
}
