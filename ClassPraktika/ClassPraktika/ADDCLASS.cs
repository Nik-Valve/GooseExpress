using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassPraktika
{
    internal class ADDCLASS
    {
        public int Count = 0;
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                if (string.IsNullOrEmpty(country) != true)
                {
                    if(Regex.IsMatch(country, @"^[a-zA-Z0-9а-яА-я-]+$") == true )Count++;
                }
                else
                {
                    Count--;
                }
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                if (string.IsNullOrEmpty(name) != true)
                {
                    if (Regex.IsMatch(name, @"^[a-zA-Z0-9а-яА-я-]+$") == true) Count++;
                }
                else
                {
                    Count--;
                }
            }
        }
        private string countday;
        public string CountDay {
            get
            {
                return countday;
            }
            set
            {
                countday = value;
                if (int.TryParse(countday, out _) == true && string.IsNullOrEmpty(countday) != true)
                {
                    Count++;
                }
                else
                {
                    Count--;
                }
            }
        }
        private string amount;
        public string Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                if (int.TryParse(amount, out _) == true && string.IsNullOrEmpty(amount) != true)
                {
                    Count++;
                }
                else
                {
                    Count--;
                }
            }
        }
    }
}
