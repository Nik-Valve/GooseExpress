using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12JanSession.Classes
{
    public class StockProduct
    {
        [StringLength(15, MinimumLength = 15, ErrorMessage = "Длина артикула товара должна быть равна 15 символам!")]
        public string Code { get; set; } = string.Empty;

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Длина строки должна быть от 1 до 50 символов!")]
        public string ProductName { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Стоимость не может быть отрицательной!")]
        public double Cost { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Длина строки должна быть от 1 до 50 символов!")]
        public string Manufacturer { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Вес не может быть отрицательным!")]
        public double WeightInKg { get; set; }
    }
}
