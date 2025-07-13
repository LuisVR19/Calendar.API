using Calendar.Data.Interfaces;
using Calendar.Data.Mapper;
using Calendar.Data.Models;
using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Data.Repositories
{
    public class AssigmentRepository : IAssigmentRepository
    {
        private readonly CalendarDBContext _context;

        public AssigmentRepository(CalendarDBContext context)
        {
            _context = context;
        }

        public bool InsertAssigment(AssigmentDTO assigmentDto)
        {
            Assigment assigment = AutoMapperHelper.Map<AssigmentDTO, Assigment>(assigmentDto);

            assigment.WeekDays = GetWeekDaysByAssigment(assigmentDto);

            _context.Assigments.Add(assigment);
            int affectedRows = _context.SaveChanges();
            return affectedRows > 0;
        }

        public bool UpdateAssigment(AssigmentDTO assigmentDto)
        {
            var assigment = _context.Assigments
               .Include(a => a.WeekDays)
               .FirstOrDefault(a => a.AssigmentId == assigmentDto.AssigmentId);

            AutoMapperHelper.MapProperties(assigmentDto, assigment);

            assigment.WeekDays.Clear();
            assigment.WeekDays = GetWeekDaysByAssigment(assigmentDto);

            int affectedRows = _context.SaveChanges();
            return affectedRows > 0;
        }

        public bool ExistsAssigment(AssigmentDTO assigmentDto)
        {
            Assigment? assigment = _context.Assigments
                .Where(a => a.Description == assigmentDto.Description && a.User.UserId == assigmentDto.User.UserId)
                .FirstOrDefault();
            return assigment != null;
        }

        public List<AssigmentDTO> GetMonthRecord(CalendarFilterDTO request)
        {
            List<Assigment> list = new List<Assigment>();

            list = _context.Assigments
                .Where(a => a.UserId == request.UserId)
                .Select(a => new Assigment
                {
                    AssigmentId = a.AssigmentId,
                    Description = a.Description,
                    UserId = a.UserId,
                    User = a.User,
                    GroupId = a.GroupId,
                    Group = a.Group,
                    PriorityId = a.PriorityId,
                    Priority = a.Priority,
                    WeekDays = a.WeekDays,
                    AssigmentRecords = a.AssigmentRecords
                        .Where(th => th.Date.Month == request.month && th.Date.Year == request.year)
                        .ToList()
                })
                .ToList();

            return AutoMapperHelper.Map<List<Assigment>, List<AssigmentDTO>>(list);
        }

        private List<WeekDay> GetWeekDaysByAssigment(AssigmentDTO assigmentDto)
        {
            var weekDayIds = assigmentDto.WeekDays.Select(w => w.WeekDayId).ToList();

            return _context.WeekDays
                .Where(w => weekDayIds.Contains(w.WeekDayId))
                .ToList();
        }

        public List<AssigmentDTO> GetByUser(int userId)
        {
            List<Assigment> list = new List<Assigment>();

            list = _context.Assigments
                .Include(a => a.Priority)
                .Include(a => a.WeekDays)
                .Where(a => a.UserId == userId)
                .ToList();

            return AutoMapperHelper.Map<List<Assigment>, List<AssigmentDTO>>(list);
        }

    }
}
