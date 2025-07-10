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

        public List<AssigmentDTO> GetMonthRecord(CalendarFilterDTO request)
        {
            List<Assigment> list = new List<Assigment>();

            list = _context.Assigments
              .Include(a => a.TaskHistories)
              .Include(a => a.WeekDays) 
              .Where(a => a.UserId == request.UserId &&
                          a.TaskHistories.Any(th => th.Date.Month == request.month && th.Date.Year == request.year))
              .ToList();

            return AutoMapperHelper.Map<List<Assigment>, List<AssigmentDTO>>(list);
        }
    }
}
