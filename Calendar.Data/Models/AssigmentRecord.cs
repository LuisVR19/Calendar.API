using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calendar.Data.Models
{
    [Table("AssigmentRecord", Schema = "Assigment")]
    public class AssigmentRecord
    {
        [Key]
        public int AssigmentRecordId { get; set; }
        public DateTime Date { get; set; }
        public bool Complete { get; set; }
        public int AssigmentId { get; set; }
        public Assigment Assigment { get; set; }
    }
}
