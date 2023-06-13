using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseExpress.DataHelper
{
    public class Order
    {
        public int Id { get; set; }
        public int IDCityOut { get; set; }
        public int IDCityInp { get; set; }
        public int IDCustomer { get; set; }
        public int? IDRecipient { get; set; }
        public string AddInp { get; set; }
        public string AddrOut { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime DateTerm { get; set; }
        public decimal Cost { get; set; }
        public int IDRate { get; set; }
        public int IDStatus { get; set; }
    }
}
