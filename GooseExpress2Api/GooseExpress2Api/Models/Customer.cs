namespace GooseExpress2Api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int IdCity { get; set; }
        public string? NameOfCustomer { get; set; }
        public string LegalAddres { get; set; }
        public string Phone { get; set;}
        public string LastName { get; set;}
        public string FirstName { get; set;}
        public string? Patronymic { get; set;}
        public string Email { get; set;}
        public string Seria { get; set;}
        public string Number { get; set;}
        public string Login { get; set;}
        public string Password { get; set;}
        public byte[]? Image { get; set;}
    }
}
