﻿using System;
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
        static int CountBoxes = 0;
        public ComboBoxPumps()
        {
            InitializeComponent();
            CountBoxes++;
            this.Name = $"ComboBox{CountBoxes}";
        }

        private void AddOrDelPump(object sender, SelectionChangedEventArgs e)
        {
            
            //Grid parent = (Grid)this.Parent;
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Children.OfType<ComboBoxPumps>().Count());

            ////if ((sender as ComboBox).SelectedIndex == -1 && parent.RowDefinitions.Count > 3)
            ////    { parent. } here delete combobox

            
            //parent.RowDefinitions.Add(new RowDefinition() { MaxHeight = 25 });

            //int NumberOfPump = parent.RowDefinitions.Count - 3;
            //Label newPump = new Label { Content = $"Насос №{NumberOfPump}" };
            //parent.Children.Add(newPump);
            //Grid.SetRow(newPump, parent.RowDefinitions.Count - 1);
            //Grid.SetColumn(newPump, 0);

            //UserControl newCombo = new ComboBoxPumps();
            //parent.Children.Add(newCombo);
            //Grid.SetRow(newCombo, parent.RowDefinitions.Count - 1);
            //Grid.SetColumn(newCombo, 1);
            
        }

        //возможно добавлю позже (удаление насоса при выборе пустой (первой) строчки)
        private void DelPump(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != 0)
                return;
            StackPanel parent = (StackPanel)this.Parent;
            // ComboBox DeletedBox = (ComboBox)sender; !!!НЕ ВЕРНО!!! НУЖНО ПРИВОДИТЬ К COMBOBOXPUMPS!!! ПОКА ОСТАВЛЮ ЭТО ЗДЕСЬ, ДЛЯ НАПОМИНАНИЯ
            parent.Children.Remove(this);
        }
    }
}
