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
using System.Windows.Shapes;

using _12JanSession.Pages;

namespace _12JanSession.Windows
{
    /// <summary>
    /// Логика взаимодействия для SessionWindow.xaml
    /// </summary>
    public partial class SessionWindow : Window
    {
        public SessionWindow()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductPage productPage = new();
            /// <summary>
            /// Необязательная проверка на наличие нашей странице уже в фрейме
            /// Сделано, чтобы не плотить одинаковые экземлпяры класса Page
            /// В методе ниже не стал реализовывать
            /// </summary>
            if (MainFrame.Content is not AddProductPage)
            {
                MainFrame.Navigate(productPage);
            }
        }

        private void BtnShowProducts_Click(object sender, RoutedEventArgs e)
        {
            ProductListPage productListPage = new();
            MainFrame.Navigate(productListPage);
        }
    }
}
