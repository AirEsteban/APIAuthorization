using APIAuthorization.DBContexts;
using APIAuthorization.Interfaces;
using APIAuthorization.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace APIAuthorization.Repositories
{
    public class UsersRepository : IRepository
    {
        public MyDBContext _context { get; set; }
        public UsersRepository(MyDBContext context) 
        { 
            _context = context;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable GetAll()
        {
            IQueryable<User> users = _context.Users.Where(a => true);
            return users;
        }

        public async Task<object> GetById(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync<User>(usr => usr.UserId == id);
            return user;
        }

        public async Task Insert(object user)
        {
            await _context.Users.AddAsync((User)user);
            await _context.SaveChangesAsync();
        }

        public async Task Update(object user)
        {
            _context.Users.Update((User)user);
            await _context.SaveChangesAsync();
        }
    }
}
