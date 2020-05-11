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
        public string Address { get; set; }

        [ForeignKey("OwnerId")]
        public HolidayHomesOwner Owner { get; set; }
        
        public int OwnerId { get; set; }
    }
}
