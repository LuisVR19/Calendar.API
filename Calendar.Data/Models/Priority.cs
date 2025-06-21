using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Data.Models
{
    [Table("Priority", Schema = "catalogs")]
    public class Priority
    {
        [Key]
        public int PriorityId { get; set; }
        public int PriorityNumber { get; set; }
        public string Name { get; set; }
    }
}
