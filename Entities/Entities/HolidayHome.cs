using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class HolidayHome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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

        public ICollection<HolidayHomeImage> ImagesList { get; set; }
            = new List<HolidayHomeImage>();

        [ForeignKey("OwnerId")]
        public Owner Owner { get; set; }
        
        public int OwnerId { get; set; }
    }
}
