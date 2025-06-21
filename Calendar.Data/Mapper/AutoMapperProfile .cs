using AutoMapper;
using Calendar.Data.Models;
using Calendar.Entities.DTOs;

namespace Calendar.Data.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {

            CreateMap<User, UserDTO>();

        }
    }
}
