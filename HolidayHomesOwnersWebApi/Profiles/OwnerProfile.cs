using AutoMapper;
using Models;

namespace HolidayHomesOwnersWebApi.Profiles
{
    public class OwnerProfile: Profile
    {
        public OwnerProfile()
        {
            CreateMap<Entities.Owner, OwnerDto>();
        }
    }
}
