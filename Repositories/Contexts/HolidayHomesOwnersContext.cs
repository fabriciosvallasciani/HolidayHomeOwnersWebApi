using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Contexts
{
    public class HolidayHomesOwnersContext: DbContext
    {
        public DbSet<HolidayHomesOwner> HolidayHomesOwners { get; set; }
        public DbSet<HolidayHome> HolidayHomes { get; set; }

        public HolidayHomesOwnersContext(DbContextOptions<HolidayHomesOwnersContext> options)
            : base(options)
        {
        }
    }
}
