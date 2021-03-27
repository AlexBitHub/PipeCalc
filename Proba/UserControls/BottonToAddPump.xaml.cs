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
    /// Логика взаимодействия для BottonToAddPump.xaml
    /// </summary>
    public partial class BottonToAddPump : UserControl
    {
        public BottonToAddPump()
        {
            InitializeComponent();
        }

        private void AddPump(object sender, RoutedEventArgs e)
        {
            Grid parent = (Grid)this.Parent;
            Console.WriteLine(parent);
            Console.WriteLine(parent.Children.OfType<ComboBoxPumps>().Count());

            //if ((sender as ComboBox).SelectedIndex == -1 && parent.RowDefinitions.Count > 3)
            //    { parent. } here delete combobox
            
            // добавляем новый Row в Grid
            parent.RowDefinitions.Add(new RowDefinition() { MaxHeight = 30 });
            
            // смещаем кнопку на один Row вниз
            Grid.SetRow(this, parent.RowDefinitions.Count - 1);

            // колво насосов (для подписи насоса, нулевой не может быть)
            int NumberOfPump = parent.Children.OfType<ComboBoxPumps>().Count() + 1;

            // добавляем подпись в Row над кнопкой
            Label newPump = new Label { Content = $"Насос №{NumberOfPump}" };
            parent.Children.Add(newPump);
            Grid.SetRow(newPump, parent.RowDefinitions.Count - 2);
            Grid.SetColumn(newPump, 0);
            
            // добавляем СomboBox в Row над кнопкой
            UserControl newCombo = new ComboBoxPumps();
            parent.Children.Add(newCombo);
            Grid.SetRow(newCombo, parent.RowDefinitions.Count - 2);
            Grid.SetColumn(newCombo, 1);
        }
    }
}
