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
            CreateMap<UserDTO, User>();

            CreateMap<AssigmentDTO, Assigment>();
            CreateMap<Assigment, AssigmentDTO>();

            CreateMap<AssigmentRecordDTO, AssigmentRecord>();
            CreateMap<AssigmentRecord, AssigmentRecordDTO>();


            CreateMap<WeekDayDTO, WeekDay>();
            CreateMap<WeekDay, WeekDayDTO>();

            CreateMap<PriorityDTO, Priority>();
            CreateMap<Priority, PriorityDTO>();

        }
    }
}
