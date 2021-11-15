using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeCalcForm
{
    public partial class CoordinateAndHighMarkForm : Form
    {
        public CoordinateAndHighMarkForm()
        {
            InitializeComponent();
            IList<int> X_Spots = new List<int>(Enumerable.Range(0, 121)).Where(x => x % 5 == 0).ToList();
            IList<int> Z_Spots = new List<int>();
            for (int i = 0; i < X_Spots.Count; i++)
            {
                Z_Spots.Add(new Random().Next(35, 55));
            }


            var source = new BindingSource();

            DataTable tab = new DataTable();
            tab.Columns.Add("Координата, км", typeof(double));
            tab.Columns.Add("Высотная отметка, м", typeof(double));
            
            for (int i = 0; i < X_Spots.Count; i++)
            {
                tab.Rows.Add(X_Spots[i], Z_Spots[i]);
            }

            dataGridXandZ.DataSource = tab;

            tab.Rows.Add(200, 100);
        }
    }
}
