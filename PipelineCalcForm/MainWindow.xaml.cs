using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PipelineCalcForm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void OneTabNps_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TabItem newTi = new TabItem();
            Grid TabGrid = new Grid();
            RowDefinition TabRow = new RowDefinition();
            ColumnDefinition TabColumn = new ColumnDefinition();
            
            TabGrid.ColumnDefinitions.Add(TabColumn);
            TabGrid.ColumnDefinitions.Add(TabColumn);
            //for (int i = 0; i < 4; i++)
            //{
            //    TabGrid.RowDefinitions.Add(TabRow);
            //}


            Label lb1 = new Label() { Content = "Высотная отметка, м" };
            Label lb2 = new Label() { Content = "Координата, км" };
            TextBox tb1 = new TextBox();
            TextBox tb2 = new TextBox();

            //TabItem ti = TabsOfNPS.SelectedItem as TabItem;
            //ti.Header = $"НПС №{TabsOfNPS.Items.Count}";

        }
    }
}
