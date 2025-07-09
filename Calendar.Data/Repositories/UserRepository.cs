using Calendar.Data.Interfaces;
using Calendar.Data.Mapper;
using Calendar.Data.Models;
using Calendar.Entities.DTOs;

namespace Calendar.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CalendarDBContext _context;

        public UserRepository(CalendarDBContext context)
        {
            _context = context;
        }
        public UserDTO GetUserById(int id)
        {
            User user = _context.Users.Where(u => u.UserId == id).FirstOrDefault();

            return AutoMapperHelper.Map<User, UserDTO>(user);
        }

        public bool InsertUser(UserDTO userDto)
        {
            User user = AutoMapperHelper.Map<UserDTO, User>(userDto);
            _context.Users.Add(user);

            int affectedRows = _context.SaveChanges();

            return affectedRows > 0;
        }
    }
}
