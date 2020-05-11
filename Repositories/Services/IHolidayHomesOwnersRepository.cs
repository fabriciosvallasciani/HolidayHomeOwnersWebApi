using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Services
{
    public interface IHolidayHomesOwnersRepository
    {
        Task Add(int ownerId, HolidayHome newHome);

        Task<bool> Exists(int ownerId);

        Task<HolidayHomesOwner> Get(int ownerId);

        Task<IEnumerable<HolidayHomesOwner>> GetAll();

        Task<HolidayHome> Get(int ownerId, int homeId);

        Task<IEnumerable<HolidayHome>> GetHomes(int ownerId);

        Task<bool> Save();

        void Update(int ownerId, HolidayHome homeEntity);

        void Remove(HolidayHome homeFromStore);
    }
}
