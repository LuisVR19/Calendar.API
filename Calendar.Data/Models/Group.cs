using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Data.Models
{
    [Table("Group", Schema = "User")]
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
