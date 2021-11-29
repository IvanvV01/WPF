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
using System.IO;
using System.Collections;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            if(FruitBox.SelectedItem == null)
            {
                MessageBox.Show("Select an item to move", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int newIndex = FruitBox.SelectedIndex - 1;

                if(newIndex < 0)
                {
                    return;
                }
                
                object selectedItem = FruitBox.SelectedItem;
                FruitBox.Items.Remove(selectedItem);
                FruitBox.Items.Insert(newIndex, selectedItem);
               // FruitBox.SetSelected(newIndex, true);
            }
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if(FruitBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to move", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int newIndex = FruitBox.SelectedIndex + 1;

                if (newIndex >= FruitBox.Items.Count)
                {
                    return;
                }

                object selectedItem = FruitBox.SelectedItem;
                FruitBox.Items.Remove(selectedItem);
                FruitBox.Items.Insert(newIndex, selectedItem);
                //FruitBox.SetSelected(newIndex, true);
            }

        }

        private void FruitBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
