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

namespace Proba
{
    /// <summary>
    /// Логика взаимодействия для NewTab.xaml
    /// </summary>
    public partial class ContentNewTabOfNps : UserControl
    {
        public static int CountTabs = 0;
        public ContentNewTabOfNps()
        {
            InitializeComponent();
            CountTabs++;
        }

        // если первый ComboBox добавлен не как UserControl
        //private void AddOrDelPump(object sender, SelectionChangedEventArgs e)
        //{
        //    ////if ((sender as ComboBox).SelectedIndex == -1 && )
        //    ////(sender as ComboBox).
        //    Grid parent = (Grid)VisualTreeHelper.GetParent(sender as ComboBox);
        //    Console.WriteLine(parent);
        //    parent.RowDefinitions.Add(new RowDefinition() { });


        //    Label newPump = new Label { Content = "Насос №{NumberOfPump}" };
        //    parent.Children.Add(newPump);
        //    Grid.SetRow(newPump, parent.RowDefinitions.Count - 1);
        //    Grid.SetColumn(newPump, 0);

        //    UserControl newCombo = new UserControl1();
        //    parent.Children.Add(newCombo);
        //    Grid.SetRow(newCombo, parent.RowDefinitions.Count - 1);
        //    Grid.SetColumn(newCombo, 1);
        //}
    }
}
