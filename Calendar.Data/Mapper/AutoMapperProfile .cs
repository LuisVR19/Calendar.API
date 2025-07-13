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

            CreateMap<AssigmentDTO, Assigment>()
               .ForMember(dest => dest.User, opt => opt.Ignore())
               .ForMember(dest => dest.Priority, opt => opt.Ignore())
               .ForMember(dest => dest.AssigmentRecords, opt => opt.Ignore());
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
