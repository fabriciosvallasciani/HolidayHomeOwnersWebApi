using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HolidayHomeForUpdateDto
    {
        [Required]
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
    }
}
