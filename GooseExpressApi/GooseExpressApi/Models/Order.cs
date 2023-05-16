namespace GooseExpressApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdCityOut { get; set; }
        public int IdCityInp { get; set; }
        public int IdCustomer { get; set; }
        public int? IdRecipients { get; set; }
        public string AddrInp { get; set; }    
        public string AddrOut { get; set; }    
        public DateTime DateOrdere { get; set; }    
        public DateTime DateTerm { get; set; }    
        public decimal Cost { get; set; }
        public int IdRate { get; set;}
        public int IdStatus { get; set;}
    }
}
