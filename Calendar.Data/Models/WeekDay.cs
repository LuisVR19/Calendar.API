using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Data.Models
{
    [Table("WeekDays", Schema = "catalogs")]
    public class WeekDay
    {
        [Key]
        public int WeekDayId { get; set; }
        public string Name { get; set; }
        public int Day { get; set; }
    }
}
