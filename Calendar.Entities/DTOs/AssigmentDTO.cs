using System.Text.Json.Serialization;

namespace Calendar.Entities.DTOs
{
    public class AssigmentDTO
    {
        public int AssigmentId { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public int UserId { 
                get => User?.UserId ?? 0;
        }
        public UserDTO User { get; set; }
        //public Group Group { get; set; }
        [JsonIgnore]
        public int PriorityId { 
            get => Priority?.PriorityId ?? 0;
        }
        public PriorityDTO Priority { get; set; }

        public ICollection<WeekDayDTO> WeekDays { get; set; }
        public List<AssigmentRecordDTO> AssigmentRecords { get; set; }
    }
}
