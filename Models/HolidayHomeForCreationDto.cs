using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HolidayHomeForCreationDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        [Range(byte.MinValue, byte.MaxValue)]
        public byte Bedrooms { get; set; }

        [Range(uint.MinValue, uint.MaxValue)]
        public uint LivingArea { get; set; }

        public bool HasWiFi { get; set; }

        [Required]
        [Range(byte.MinValue, byte.MaxValue)]
        public byte Sleeps { get; set; }

        [Range(uint.MinValue, uint.MaxValue)]
        public uint TerraceArea { get; set; }

        public bool HasBalcony { get; set; }

        [Required]
        [Range(byte.MinValue, byte.MaxValue)]
        public byte Bathrooms { get; set; }

        [Range(uint.MinValue, uint.MaxValue)]
        public uint GardenArea { get; set; }

        public bool HasPatio { get; set; }

        [Range(byte.MinValue, byte.MaxValue)]
        public byte DistanceToAirport { get; set; }

        [Range(byte.MinValue, byte.MaxValue)]
        public byte DistanceToBeach { get; set; }

        [Range(byte.MinValue, byte.MaxValue)]
        public byte DistanceToShopping { get; set; }

        public ICollection<HolidayHomeImageDto> ImagesList { get; set; }
    }
}
