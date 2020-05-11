using AutoMapper;
using Models;

namespace HolidayHomesOwnersWebApi.Profiles
{
    public class HolidayHomesOwnerProfile: Profile
    {
        public HolidayHomesOwnerProfile()
        {
            CreateMap<Entities.HolidayHomesOwner, HolidayHomesOwnerBaseDto>();
        }
    }
}
