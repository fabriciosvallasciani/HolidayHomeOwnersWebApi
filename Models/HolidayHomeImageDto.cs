using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HolidayHomeImageDto
    {
        public int Id { get; set; }

        public string Description { get; set; }

        [Required]
        public string Url { get; set; }
    }
}
