using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;

namespace Calendar.Data.Interfaces
{
    public interface IAssigmentRepository
    {
        bool InsertAssigment(AssigmentDTO assigmentDto);
        bool UpdateAssigment(AssigmentDTO assigmentDto);
        bool ExistsAssigment(AssigmentDTO assigmentDto);
        List<AssigmentDTO> GetByUser(int userId);
        List<AssigmentDTO> GetMonthRecord(CalendarFilterDTO req);
    }
}
