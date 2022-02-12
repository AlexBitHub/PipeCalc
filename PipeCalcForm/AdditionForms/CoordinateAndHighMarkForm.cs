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
    public partial class CoordinateAndHighMarkForm : Form
    {
        public List<Mark> marksList = new List<Mark>();
        BindingList<Mark> bindingMarks;
        double _lengthPipe;
        double _endHigh;

        public CoordinateAndHighMarkForm(double length, double endHigh)
        {
            InitializeComponent();
            _lengthPipe = length;
            _endHigh = endHigh;
        }

        private void CoordinateAndHighMarkForm_Shown(object sender, EventArgs e)
        {
            var lengthPipe = (int)Math.Floor(_lengthPipe);

            if(marksList == null) // если запускаем первый раз окно (т.е.массив с координатами пустой) подготовливаем все координаты
            {
                marksList = new List<int>(Enumerable.Range(0, lengthPipe)).Where(x => x % 5 == 0).Select(x => new Mark(x)).ToList();
                marksList.Add(new Mark(_lengthPipe, _endHigh));                              
            }
            bindingMarks = new BindingList<Mark>(marksList);
            var source = new BindingSource(bindingMarks, null);
            dataGridXandZ.DataSource = source;
            //dataGridXandZ.Rows[marksList.Count - 1].Frozen = true;
        }

        private void buttonRandHigMarks_Click(object sender, EventArgs e)
        {
            var z_Rand = new Random();
            for (int i = 0; i < marksList.Count; i++)
            {                
                marksList[i].High_mark = z_Rand.Next(35, 55);
            }
            dataGridXandZ.Refresh();
        }
    }
}
