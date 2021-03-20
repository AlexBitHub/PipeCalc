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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class ComboBoxPumps : UserControl
    {
        public ComboBoxPumps()
        {
            InitializeComponent();
        }

        private void AddOrDelPump(object sender, SelectionChangedEventArgs e)
        {
            
            Grid parent = (Grid)this.Parent;
            Console.WriteLine(parent);
            Console.WriteLine(parent.Children.OfType<ComboBoxPumps>().Count());

            //if ((sender as ComboBox).SelectedIndex == -1 && parent.RowDefinitions.Count > 3)
            //    { parent. } here delete combobox

            
            parent.RowDefinitions.Add(new RowDefinition() { MaxHeight = 25 });

            int NumberOfPump = parent.RowDefinitions.Count - 3;
            Label newPump = new Label { Content = $"Насос №{NumberOfPump}" };
            parent.Children.Add(newPump);
            Grid.SetRow(newPump, parent.RowDefinitions.Count - 1);
            Grid.SetColumn(newPump, 0);

            UserControl newCombo = new ComboBoxPumps();
            parent.Children.Add(newCombo);
            Grid.SetRow(newCombo, parent.RowDefinitions.Count - 1);
            Grid.SetColumn(newCombo, 1);
        }
    }
}
