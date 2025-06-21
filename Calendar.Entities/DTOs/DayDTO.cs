namespace Calendar.Entities.DTOs
{
    public class DayDTO
    {
        public DateTime Date { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public bool IsHoliday => !string.IsNullOrEmpty(HolidayName);
        public string? HolidayName { get; set; }
        public List<AssigmentDTO> assigments { get; set; }
    }
}
