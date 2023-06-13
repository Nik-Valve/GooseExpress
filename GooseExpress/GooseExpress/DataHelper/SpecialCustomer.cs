using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseExpress.DataHelper
{
    public class SpecialCustomer
    {
        public int Id { get; set; }
        public int Seria { get; set; }
        public int Number { get; set; }
        public string NameOfCity { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string LegalAddres { get; set; }
        public string Phone { get; set; }
        public string NameOfCustomer { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
    }
}
