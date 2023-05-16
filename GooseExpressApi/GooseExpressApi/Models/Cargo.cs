namespace GooseExpressApi.Models
{
    public class Cargo
    {
        public int Id { get; set; }
        public int IdTypeCargo { get; set; }
        public string NameOfCargo { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
        public int IdOrder { get; set; }
    }
}
