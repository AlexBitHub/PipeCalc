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

        /// <summary>
        /// Добавляет новую вкладку при двойном щелчке на название (только для вкладки ГНПС)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewTabOfNps(object sender, MouseButtonEventArgs e)
        {
            //создаю новую вкладку
            TabItem NewTabOfNps = new TabItem() { Height = 25 };
            
            //название для вкладки и обработчик на её удаление
            Label NameOfNps = new Label() { Content = $"ППС №{TabsOfNps.Items.Count}", Height = 25 };
            NameOfNps.MouseDoubleClick += DeleteTabOfNps;
            
            //добавляю название в заголовок вкладки
            NewTabOfNps.Header = NameOfNps;

            //добавляю во вкладку содержание 
            NewTabOfNps.Content = new ContentNewTabOfNps();
            TabsOfNps.Items.Add(NewTabOfNps);
        }

        /// <summary>
        /// Удаляет вкладку при двойном щелчке на название (только не для вкладки ГНПС)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTabOfNps(object sender, MouseButtonEventArgs e)
        {
            var DeletedItem = (sender as Label).Parent;
            TabsOfNps.Items.Remove(DeletedItem);
        }
    }
}
