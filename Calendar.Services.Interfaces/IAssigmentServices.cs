using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.Contracts;
using Calendar.Entities.DTOs;

namespace Calendar.Services.Interfaces
{
    public interface IAssigmentServices
    {
        ResponseDTO InsertAssigment(RequestDTO<BaseFilterDTO, AssigmentDTO> request);
        ResponseDTO UpdateAssigment(RequestDTO<BaseFilterDTO, AssigmentDTO> request);
        ResponseDTO GetByUser(RequestDTO<BaseFilterDTO, Object> request);
    }
}
