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
    }
}
