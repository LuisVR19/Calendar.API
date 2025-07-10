namespace Calendar.Entities.DTOs
{
    public class AssigmentRecordDTO
    {
        public int AssigmentRecordId { get; set; }
        public DateTime Date { get; set; }
        public bool Complete { get; set; }
        public AssigmentDTO Assigment { get; set; }
    }
}
