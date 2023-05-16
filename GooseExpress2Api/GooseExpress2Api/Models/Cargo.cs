namespace GooseExpress2Api.Models
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
