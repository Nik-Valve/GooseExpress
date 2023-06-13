using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseExpress.DataHelper
{
    public class HistoryOrder
    {
        public int Id { get; set; }
        public  string NameOfCargo { get; set; }
        public  string LastName { get; set; }
        public  decimal Cost { get; set; }
        public  DateTime DateOrder { get; set; }
        public DateTime DateTerm { get; set; }


    }
}
