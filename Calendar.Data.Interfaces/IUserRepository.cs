using Calendar.Entities.DTOs;

namespace Calendar.Data.Interfaces
{
    public interface IUserRepository
    {
        UserDTO GetUserById(int id);
        bool InsertUser(UserDTO userDto);
        bool ExistsUser(UserDTO userDto);

    }
}
