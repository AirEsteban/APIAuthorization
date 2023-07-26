using APIAuthorization.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace APIAuthorization.DBContexts
{
    public class MyDBContext : DbContext
    {
        DbContextOptions DbContextOptions { get; set; }
        public MyDBContext(DbContextOptions options) : base(options){
            DbContextOptions = options;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Publication> Publications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { UserId = 1, Name="Esteban" });
        }


    }
}
