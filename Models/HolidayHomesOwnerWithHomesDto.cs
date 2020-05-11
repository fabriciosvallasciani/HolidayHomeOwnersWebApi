using System.Collections.Generic;

namespace Models
{
    public class HolidayHomesOwnerWithHomesDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<HolidayHomeDto> HolidayHomes { get; set; } 
            = new List<HolidayHomeDto>();
    }
}
