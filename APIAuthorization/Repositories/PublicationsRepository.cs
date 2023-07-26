using APIAuthorization.DBContexts;
using APIAuthorization.Interfaces;

namespace APIAuthorization.Repositories
{
    public class PublicationsRepository 
    {
        public MyDBContext _context { get; set; }

        public PublicationsRepository(MyDBContext dbContext)
        {
            _context = dbContext;
        }
    }
}
