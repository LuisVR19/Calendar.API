using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;

namespace Calendar.Data.Interfaces
{
    public interface IAssigmentRepository
    {
        List<AssigmentDTO> GetMonthRecord(CalendarFilterDTO req);
    }
}
