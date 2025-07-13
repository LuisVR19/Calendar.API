using Calendar.Data.Interfaces;
using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;
using Calendar.Services.Bases;
using Calendar.Services.Interfaces;
using Calendar.Services.Interfaces.External;

namespace Calendar.Services
{
    public class CalendarServices : BaseService, ICalendarServices
    {
        private readonly IAssigmentRepository _repository;
        private readonly IHolidayProvider _HolidayService;

        public CalendarServices(IAssigmentRepository repository, IHolidayProvider holidayService)
        {
            _repository = repository;
            _HolidayService = holidayService;
        }

        public async Task<ResponseDTO> GetMonthByDate(RequestDTO<CalendarFilterDTO, Object> request)
        {
            try
            {
                ResponseDTO response = new ResponseDTO();

                List<DayDTO> selectedMonth = await GenerateMonth(request.filter);
                response.Data = selectedMonth;
                return response;
            }
            catch (Exception ex)
            {
                //return GenericExceptionResult(ex);
                return null;
            }
        }

        private async Task<List<DayDTO>> GenerateMonth(CalendarFilterDTO request)
        {
            var days = new List<DayDTO>();
            int totalDays = DateTime.DaysInMonth(request.year, request.month);

            List<HolidayDTO> holidays = await _HolidayService.GetHolidaysAsync(request.year, request.CountryCode);
            
            List<AssigmentDTO> assigments = _repository.GetMonthRecord(request);

            for (int i = 1; i <= totalDays; i++)
            {
                var newDay = new DateTime(request.year, request.month, i);
                var holiday = holidays.FirstOrDefault(h => h.Date.Date == newDay.Date);

                days.Add(new DayDTO
                {
                    Date = newDay,
                    WeekDay = newDay.DayOfWeek,
                    HolidayName = holiday?.LocalName,
                    assigments = assigments.Where(a => a.WeekDays.Any(wk => wk.Day == (int)newDay.DayOfWeek)).ToList()
                });
            }

            return days;
        }

    }
}
