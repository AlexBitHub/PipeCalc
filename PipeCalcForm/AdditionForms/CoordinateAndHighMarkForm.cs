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

        MainForm owner;
        public CoordinateAndHighMarkForm()
        {
            InitializeComponent();
        }

        private void CoordinateAndHighMarkForm_Shown(object sender, EventArgs e)
        {
            owner = this.Owner as MainForm;
            var lengthPipe = (int)Math.Floor(owner.LengthPipeline);

            if(marksList == null) // если запускаем первый раз окно (т.е.массив с координатами пустой) подготовливаем все координаты
            {
                marksList = new List<int>(Enumerable.Range(0, lengthPipe)).Where(x => x % 5 == 0).Select(x => new Mark(x)).ToList();
                marksList.Add(new Mark(owner.LengthPipeline, owner.EndHighMark));                              
            }
            bindingMarks = new BindingList<Mark>(marksList);
            var source = new BindingSource(bindingMarks, null);
            dataGridXandZ.DataSource = source;
            //dataGridXandZ.Rows[marksList.Count - 1].Frozen = true;
            //dataGridXandZ.Columns[0].Name = "Коодината, км";
            //dataGridXandZ.Columns[1].Name = "Высотная отметка, м";
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
