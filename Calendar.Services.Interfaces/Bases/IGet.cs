using Calendar.Entities.Contracts;

namespace Calendar.Services.Interfaces.Bases
{
    public interface IGet
    {
        ResponseDTO GetById(int id);
    }
}
