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
        public ContentNewTabOfNps()
        {
            InitializeComponent();
        }

        private void AddPump_Click(object sender, RoutedEventArgs e)
        {
            StackPanel parent = (StackPanel)(sender as Button).Parent;
            ComboBoxPumps newCombo = new ComboBoxPumps();

            // настраиваем отступы
            newCombo.Margin = new Thickness(1, 2, 1, 2);
            // добавляем СomboBox в StackPanel 
            parent.Children.Add(newCombo);
        }
    }
}
