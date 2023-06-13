using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseExpress.DataHelper
{
    public class Cargo
    {
        public int Id { get; set; }
        public int IDTypeCargo { get; set; }
        public string NameOfCargo { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public int IDOrder { get; set; }
    }
}
