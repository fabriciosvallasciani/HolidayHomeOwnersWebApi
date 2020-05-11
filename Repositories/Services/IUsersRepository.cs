using System.Threading.Tasks;

namespace Repositories.Services
{
    public interface IUsersRepository
    {
        Task<bool> Authorize(string emailAddress, string password);
    }
}
