using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.Contracts;

namespace Calendar.Services.Interfaces
{
    public interface IAssigmentServices
    {
        ResponseDTO InsertAssigment(RequestDTO<BaseFilterDTO> request);
    }
}
