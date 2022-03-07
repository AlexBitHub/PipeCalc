using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeCalcForm.AdditionForms
{
    public partial class TestinComboBoxGrid : Form
    {
        public TestinComboBoxGrid()
        {
            InitializeComponent();

            //BindingList<User> users = new BindingList<User> { new User() { UserName = "Fred", userid = 2 }, new User() { UserName = "Tom", userid = 1 }, new User() { UserName = "Fred", userid = 3 } };
            IList<MyValue> values = new List<MyValue> { new MyValue { id = 1, name = "Fred" }, new MyValue { id = 2, name = "Tom" } };

            //dataGridView1.DataSource = users;

            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
            
            col.DataSource = values;
            col.DisplayMember = "name";
            col.DataPropertyName = "userid";
            col.ValueMember = "id";
            dataGridView1.Columns.Add(col);
            col.DataGridView.Rows.Add(1);
            //dataGridView1.Rows.Add(1);
            dataGridView1.Rows[0].Cells[0].Value = 1;
            dataGridView1.Rows[1].Cells[0].Value = 2;
        }
    }

    public class MyValue
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class User
    {
        public string UserName { get; set; }
        public int userid { get; set; }
    }
}
