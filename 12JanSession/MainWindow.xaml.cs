using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _12JanSession
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            #region UserFieldsValidation
            if (!double.TryParse(tbPrice.Text, out double validationNumber))
            {
                ShowErrorMessage("Вы ввели неккоректное значение в поле стоимости!");
                return;
            }

            if (!double.TryParse(tbWeight.Text, out validationNumber))
            {
                ShowErrorMessage("Вы ввели неккоректное значение в поле веса товара!");
                return;
            }
            #endregion

            Appliances newAppliance = AddNewProduct();

            bool isValid = ValidationMethod(newAppliance);

            if (isValid && newAppliance.IsValid)
            {
                MessageBox.Show(newAppliance.Price.ToString() + "\nТестовое свойство: " + newAppliance.ForTest);
            }
        }

        private Appliances AddNewProduct()
        {
            Appliances appliance = new()
            {
                ProductName = tbProductName.Text,
                Price = Convert.ToDouble(tbPrice.Text),
                Description = tbDescription.Text,
                WeightInKg = Convert.ToDouble(tbWeight.Text),
                Phone = "+79055117604",
                Email = "andrey@mail.ru",
                ForTest = "+sdsds+"
            };

            return appliance;
        }

        private bool ValidationMethod(Appliances appliance)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(appliance);

            if (!Validator.TryValidateObject(appliance, context, results, true))
            {
                foreach (var error in results)
                {
                    ShowErrorMessage(error.ErrorMessage);
                    return false;
                }
            }
            return true;
        }

        private void ShowErrorMessage(string errorText)
        {
            MessageBox.Show(errorText, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
