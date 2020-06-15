using AutoMapper;
using Models;

namespace HolidayHomesOwnersWebApi.Profiles
{
    public class HolidayHomeProfile: Profile
    {
        public HolidayHomeProfile()
        {
            CreateMap<Entities.HolidayHomeImage, HolidayHomeImageDto>();
            CreateMap<Entities.HolidayHome, HolidayHomeDto>();
            CreateMap<HolidayHomeForCreationDto, Entities.HolidayHome>();
            CreateMap<HolidayHomeForUpdateDto, Entities.HolidayHome>();
        }
    }
}
