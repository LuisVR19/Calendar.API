using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Data.Models
{
    [Table("Assigment", Schema = "Assigment")]
    public class Assigment
    {
        [Key]
        public int AssigmentId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        public ICollection<WeekDay> WeekDays { get; set; }
        public ICollection<AssigmentRecord> TaskHistories { get; set; }
    }
}
