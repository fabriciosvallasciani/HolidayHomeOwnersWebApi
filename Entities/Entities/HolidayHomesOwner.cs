using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class HolidayHomesOwner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<HolidayHome> HolidayHomes { get; set; }
            = new List<HolidayHome>();
    }
}
