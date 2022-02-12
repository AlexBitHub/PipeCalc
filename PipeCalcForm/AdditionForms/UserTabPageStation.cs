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
                return new Mark(double.Parse(txtBoxCoordinate.Text), double.Parse(txtBoxHighMark.Text));
            }
        }

        public UserTabPageStation()
        {
            InitializeComponent();
            Pump pumpOne = new Pump(10, 11, 12, 13, "Pump 1");
            Pump pumpTwo = new Pump(20, 21, 22, 23, "Pump 2");
            Pump pumpThree = new Pump(30, 31, 32, 33, "Pump 3");
            List<Pump> source = new List<Pump> { pumpOne, pumpTwo, pumpThree };

            Pump mainpumpOne = new Pump(50, 10, 11, 12, 13, 10, 11, 12, 13, "Main Pump 1");
            Pump mainpumpTwo = new Pump(48, 20, 21, 22, 23, 20, 21, 22, 23, "Main Pump 2");
            Pump mainpumpThree = new Pump(46, 30, 31, 32, 33, 30, 31, 32, 33, "Main Pump 3");
            List<Pump> mainPumpsSource = new List<Pump> { mainpumpOne, mainpumpTwo, mainpumpThree };

            columnCmbBoxBoostPumps.DataSource = source;
            columnCmbBoxBoostPumps.DisplayMember = "Name";

            columnCmbBoxMainPumps.DataSource = mainPumpsSource;
            columnCmbBoxMainPumps.DisplayMember = "Name";
        }

        public List<Pump> pumpsOfStation()
        {
            var listPumps = new List<Pump>();
            var pumps = columnCmbBoxBoostPumps.Items;
            foreach (var p in pumps)
            {
                listPumps.Add(p as Pump);
            }
            return listPumps;
        }
    }
}
