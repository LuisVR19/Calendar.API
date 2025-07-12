namespace Calendar.Entities.DTOs
{
    public class AssigmentDTO
    {
        public int AssigmentId { get; set; }
        public string Description { get; set; }
        public UserDTO User { get; set; }
        //public Group Group { get; set; }
        //public Priority Priority { get; set; }
        public PriorityDTO Priority { get; set; }

        public ICollection<WeekDayDTO> WeekDays { get; set; }
        public List<AssigmentRecordDTO> AssigmentRecords { get; set; }
    }
}
