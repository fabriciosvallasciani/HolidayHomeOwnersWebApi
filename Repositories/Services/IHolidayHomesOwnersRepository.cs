using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Services
{
    public interface IHolidayHomesOwnersRepository
    {
        Task Add(uint ownerId, HolidayHome newHome);

        Task<bool> Exists(uint ownerId);

        Task<Owner> Get(uint ownerId);

        Task<IEnumerable<Owner>> GetAll();

        Task<HolidayHome> Get(uint ownerId, uint homeId);

        Task<IEnumerable<HolidayHome>> GetHomes(uint ownerId);

        Task<bool> Save();

        void Update(uint ownerId, HolidayHome homeEntity);

        void Remove(HolidayHome homeFromStore);
    }
}
