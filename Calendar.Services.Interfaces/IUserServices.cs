using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;
using Calendar.Services.Interfaces.Bases;

namespace Calendar.Services.Interfaces
{
    public interface IUserServices : IGet
    {
        //ResponseDTO GetUserById(int id);
        ResponseDTO InsertUser(RequestDTO<BaseFilterDTO> request);
    }
}
