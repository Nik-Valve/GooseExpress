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

using _12JanSession.Classes;
using static _12JanSession.Classes.StockProductList;

namespace _12JanSession.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        public ProductListPage()
        {
            InitializeComponent();

            // Установка источника данных
            LV_Products.ItemsSource = StockProducts;

            /// <summary>
            /// Необязательная проверка, если делать только эту страничку
            /// Проверяет есть ли элементы в ListView
            /// Нужна для странички AddProductPage, чтобы при добавлении 
            /// нового товара вручную не плодилось ещё 10 циклом
            /// </summary>
            if (LV_Products.Items.Count == 0)
                AddProductsToList(StockProducts);
        }

        private void AddProductsToList(List<StockProduct> products)
        {
            // Добавление в список товаров циклом
            for (int i = 1; i <= 10; i++)
            {
                StockProduct product = new()
                {
                    Code = "Код №" + i.ToString(),
                    ProductName = "Имя №" + i.ToString(),
                    Cost = 1000 + i,
                    Manufacturer = "Поставщик №" + i.ToString(),
                    WeightInKg = 0 + (double)(i+1)/4
                };

                products.Add(product);
            }
        }
    }
}
