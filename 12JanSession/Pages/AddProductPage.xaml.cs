using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace _12JanSession.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (FormValidation())
            {
                StockProduct product = AddNewProduct();

                //if (ValidationMethod(product))
                    MessageBox.Show($"Добавлен новый товар {product.ProductName} стоимостью " + product.Cost.ToString() + "\nКод товара: " + product.Code, "Товар успешно добавлен!");

                    StockProductList.StockProducts.Add(product);
            }
        }

        // Неиспользуемая часть кода для валидации по атрибутам свойств класса StockProduct
        #region ClassValidation
        private bool ValidationMethod(StockProduct product)
        {
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(product);

            if (!Validator.TryValidateObject(product, context, results, true))
            {
                foreach (var error in results)
                {
                    ShowErrorMessage(error.ErrorMessage);
                    return false;
                }
            }
            return true;
        }
        #endregion

        private bool FormValidation()
        {
            if (string.IsNullOrEmpty(tbCode.Text) || string.IsNullOrEmpty(tbName.Text) ||
                string.IsNullOrEmpty(tbManufacturer.Text) || string.IsNullOrEmpty(tbPrice.Text) ||
                string.IsNullOrEmpty(tbWeight.Text) || string.IsNullOrEmpty(tbName.Text))
            {
                ShowErrorMessage("Вы не ввели информацию в какое-то из полей!");
                return false;
            }

            return true;
        }

        private void ShowErrorMessage(string errorText)
        {
            MessageBox.Show(errorText, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private StockProduct AddNewProduct()
        {
            StockProduct newProduct = new()
            {
                Code = tbCode.Text,
                ProductName = tbName.Text,
                Manufacturer = tbManufacturer.Text,
                Cost = Convert.ToDouble(tbPrice.Text),
                WeightInKg = Convert.ToDouble(tbWeight.Text)
            };

            return newProduct;
        }
    }
}
