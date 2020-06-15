using System.Collections.Generic;

namespace Models
{
    public class HolidayHomeDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public byte Bedrooms { get; set; }

        public uint LivingArea { get; set; }

        public bool HasWiFi { get; set; }

        public byte Sleeps { get; set; }

        public uint TerraceArea { get; set; }

        public bool HasBalcony { get; set; }

        public byte Bathrooms { get; set; }

        public uint GardenArea { get; set; }

        public bool HasPatio { get; set; }

        public byte DistanceToAirport { get; set; }

        public byte DistanceToBeach { get; set; }

        public byte DistanceToShopping { get; set; }

        public ICollection<HolidayHomeImageDto> ImagesList { get; set; }

        public ICollection<HolidayHomesOwnerDto> Owner { get; set; }
    }
}
