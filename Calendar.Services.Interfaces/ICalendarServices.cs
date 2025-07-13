using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;

namespace Calendar.Services.Interfaces
{
    public interface ICalendarServices
    {
        Task<ResponseDTO> GetMonthByDate(RequestDTO<CalendarFilterDTO, Object> request);
    }
}
