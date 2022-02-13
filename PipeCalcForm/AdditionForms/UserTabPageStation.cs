using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PipeCalcForm.AdditionForms;
using PipeCalcLibrary.Classes;


namespace PipeCalcForm.AdditionForms
{
    public partial class UserTabPageStation : UserControl
    {
        public Mark StationPosition
        {
            get
            {
                return new Mark(double.Parse(txtBoxCoordinate.Text ?? "0"), double.Parse(txtBoxHighMark.Text ?? "0"));
            }
            set
            {
                txtBoxCoordinate.Text = value.Coord_mark.ToString();
                txtBoxHighMark.Text = value.High_mark.ToString();
            }
        }

        public List<Pump> selectedPumps { get; set; } = new List<Pump>();

        public UserTabPageStation(List<Pump> pumpsStore)
        {
            InitializeComponent();

            columnCmbBoxPumps.DataSource = pumpsStore;
            BindingList<Pump> bindL = new BindingList<Pump>(selectedPumps);
            BindingSource source = new BindingSource(bindL, null);
            dataGridPumps.DataSource = source;
            columnCmbBoxPumps.DisplayMember = "Name";
        }

        public List<Pump> getPumpsOfStation()
        {
            var listPumps = new List<Pump>();
            
            var boostPumps = columnCmbBoxPumps.Items;
            foreach (var bp in boostPumps)
            {
                listPumps.Add(bp as Pump);
            }
            return listPumps;
        }
    }
}
