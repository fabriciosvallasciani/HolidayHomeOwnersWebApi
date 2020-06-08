using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class HolidayHomeImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        [ForeignKey("HolidayHomeId")]
        public int HolidayHomeId { get; set; }
    }
}
