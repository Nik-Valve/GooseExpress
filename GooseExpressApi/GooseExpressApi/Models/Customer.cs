namespace GooseExpressApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int IdCity { get; set; }
        public string NameOfCustomer { get; set; }
        public string LegalAddress { get; set; }
        public string FirstName { get; set;}
        public string Patronymic { get; set;}
        public string Email { get; set;}
        public string? Seria { get; set;}
        public string? Number { get; set;}
        public string? Login { get; set;}
        public string? Password { get; set;}
        public string? Image { get; set;}
    }
}
