namespace Calendar.Entities.Contracts.Filters
{
    public class CalendarFilterDTO : BaseFilterDTO
    {
        public int year { get; set; }
        public int month { get; set; }
        public string CountryCode { get; set; }
    }
}
