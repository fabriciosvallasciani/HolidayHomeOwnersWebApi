using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HolidayHomeForCreationDto
    {
        [Required]
        public string Address { get; set; }
    }
}
