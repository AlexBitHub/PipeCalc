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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using LiveCharts.Helpers;

namespace Proba
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

        private void play_Checked(object sender, RoutedEventArgs e)
        {
            SeriesCollection seriesColl = new SeriesCollection();
            List<float> HeadsValues = PipeCalc.FactoryClasses.CreateData().Item1;
            List<int> HighValues = PipeCalc.FactoryClasses.CreateData().Item2;
            LineSeries LineHeads = new LineSeries { Title = "Напор", Values = HeadsValues.AsChartValues() };
            LineSeries LineHigh = new LineSeries { Title = "Высотная отметка", Values = HighValues.AsChartValues() };
            seriesColl.Add(LineHeads);
            seriesColl.Add(LineHigh);
            PlotHeads.Series = seriesColl;
        }

        private void AddNewTabOfNps(object sender, MouseButtonEventArgs e)
        {
            TabItem tabItem = new TabItem();
            tabItem.Name = $"TabOfNps{TabsOfNps.Items.Count}";
            tabItem.Header = $"ППС №{TabsOfNps.Items.Count}";
            tabItem.Content = new NewTab();
            TabsOfNps.Items.Add(tabItem);
        }
    }

    //class NewTabOfNps : TabControl
    //{
    //    public int NumberTabs;

    //    public void CreateNewTab()
    //    {
    //        TabItem NewTab = new TabItem();
    //        Grid TabGrid = new Grid();

    //        ColumnDefinition ColumnsTab = new ColumnDefinition();
    //        RowDefinition RowsTab = new RowDefinition();
    //    }
    //}
}
