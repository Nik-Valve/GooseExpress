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

namespace ClassPraktika
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ADDCLASS addclass = new ADDCLASS();
            addclass.Name = txtbCity.Text;
            addclass.CountDay = txtbCount.Text;
            addclass.Amount = txtbAmount.Text;
            addclass.Country = txtbCountry.Text;
            if (addclass.Count == 4)
            {
                MessageBox.Show("OK", "Verify OK", MessageBoxButton.OK, MessageBoxImage.Question);
            }
            else
            {
                MessageBox.Show("NO", "Verify NO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
