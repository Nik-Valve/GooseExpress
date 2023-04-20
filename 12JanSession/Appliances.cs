using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _12JanSession
{
    public class Appliances
    {
        #region PropFields
        //private string _productName = string.Empty;

        //private string? _description;

        //private double _price;

        //private double _weightInKg;

        //private string _email = string.Empty;

        //private string _phone = string.Empty;
        #endregion

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Неккоретно указано или пропущено наименование товара!")]
        public string ProductName { get; set; } = string.Empty;
        
        public string? Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Указана цена меньше 0!")]
        public double Price { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Указан вес меньше 0!")]
        public double WeightInKg { get; set; }

        [EmailAddress(ErrorMessage = "Введён некорректный Email!")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Введён неправильный номер телефона!")]
        public string Phone { get; set; } = string.Empty;

        #region testing
        public bool IsValid { get; set; }

        private string _test = string.Empty;

        public string ForTest 
        {
            get => _test;
            set
            {
                if (!value.StartsWith("+"))
                {
                    ShowErrorMessage("Забыли плюсик В НАЧАЛЕ, как же так...");
                    IsValid = false;
                    return;
                }
                if (!value.EndsWith("+")) 
                {
                    ShowErrorMessage("Забыли плюсик В КОНЦЕ, как же так...");
                    IsValid = false;
                    return;
                }
                // Other conditions...

                IsValid = true;
                _test = value;
            }
        }
        #endregion

        private void ShowErrorMessage(string errorText)
        {
            MessageBox.Show(errorText, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
