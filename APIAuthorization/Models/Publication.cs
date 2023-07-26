namespace APIAuthorization.Models
{
    public class Publication
    {
        public int PublicationId { get; set; }

        public string PublicationName { get; set; } = string.Empty;
        public User? User { get; set; }
    }
}
