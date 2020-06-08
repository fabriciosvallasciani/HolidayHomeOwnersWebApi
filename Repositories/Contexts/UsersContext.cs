using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Contexts
{
    public class UsersContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { 
                    Id = 1,
                    Email = "admin@admin.com",
                    Password = "12345!"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
