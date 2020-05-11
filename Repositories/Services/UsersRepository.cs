using Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Repositories.Services
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersContext _context;

        public UsersRepository(UsersContext context)
        {
            _context = context ??
               throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> Authorize(string emailAddress, string password)
        {
            return await _context.Users.AnyAsync(user => user.Email == emailAddress && user.Password == password);
        }
    }
}
