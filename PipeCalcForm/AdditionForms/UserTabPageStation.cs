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
                return new Mark(double.Parse(txtBoxCoordinate.Text == "" ? "0" : txtBoxCoordinate.Text), 
                                double.Parse(txtBoxHighMark.Text == "" ? "0" : txtBoxHighMark.Text));
            }
            set
            {
                if (value != null)
                {
                    txtBoxCoordinate.Text = value.Coord_mark.ToString();
                    txtBoxHighMark.Text = value.High_mark.ToString();
                }                
            }
        }

        public List<Pump> pumpsStore { get; set; } = new List<Pump>();

        public UserTabPageStation(List<Pump> SelectedPumps, List<Pump> pumpsStore)
        {
            InitializeComponent();
            this.pumpsStore = pumpsStore;
            columnCmbBoxPumps.DataSource = pumpsStore;

            columnCmbBoxPumps.DisplayMember = "Name";
            columnCmbBoxPumps.ValueMember = "Name";
            if (SelectedPumps != null)
            {
                dataGridPumps.Rows.Add(SelectedPumps.Count);
                for (int i = 0; i < dataGridPumps.Rows.Count - 1; i++)
                {
                    dataGridPumps.Rows[i].Cells[0].Value = SelectedPumps[i].Name;
                }
            }
            
        }

        public List<Pump> GetPumpsOfStation()
        {
            var listPumps = new List<Pump>();

            for (int i = 0; i < dataGridPumps.Rows.Count; i++)
            {
                Pump selectPump = pumpsStore.Where(p => p.Name == dataGridPumps.Rows[i].Cells[0].Value as string).FirstOrDefault();
                if (selectPump == null)
                    continue;
                listPumps.Add(selectPump);
            }
            return listPumps;
        }
    }
}
