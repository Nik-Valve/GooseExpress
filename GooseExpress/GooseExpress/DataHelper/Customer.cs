using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseExpress.DataHelper
{
    public class Customer
    {
        //public int Id = 0;
        //public int IdCity = 0;
        //public string NameOfCustomer = "";
        //public string LegalAddres = "";
        //public string Phone = "";
        //public string LastName = "";
        //public string FirstName = "";
        //public string Patronymic = "";
        //public string Email = "";
        //public string Seria = "";
        //public string Number = "";
        //public string Login = "";
        //public string Password = "";
        //public string Image = "";
        public int Id { get; set; }
        public int IdCity { get; set; }
        public string NameOfCustomer { get; set; }
        public string LegalAddres { get; set; }
        public string Phone { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Seria { get; set; }
        public string Number { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
    }
}
