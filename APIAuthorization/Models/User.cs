using Microsoft.EntityFrameworkCore;

namespace APIAuthorization.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string? Name { get; set; }

        public IList<Publication>? Publications { get; set; }
    }
}
