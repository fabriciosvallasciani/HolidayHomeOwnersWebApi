using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HolidayHomeForUpdateDto
    {
        [Required]
        public string Address { get; set; }
    }
}
