namespace GooseExpress2Api.Models
{
    public class FeedBacks
    {
        public int Id {get; set;}
        public string Comment { get; set;}
        public string FirstName { get; set;}
        public string Lastname { get; set;}
        public byte[]? Image { get; set;}
    }
}
