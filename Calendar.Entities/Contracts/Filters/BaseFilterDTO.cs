namespace Calendar.Entities.Contracts.Filters
{
    public class BaseFilterDTO
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public bool OrderDesc { get; set; }
        public string GeneralName { get; set; }
    }
}
