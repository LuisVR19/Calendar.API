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
        private readonly IHolidayProvider _HolidayService;

        public CalendarServices(IHolidayProvider holidayService)
        {
            _HolidayService = holidayService;
        }

        public async Task<ResponseDTO> GetMonthByDate(RequestDTO<CalendarFilterDTO> request)
        {
            try
            {
                ResponseDTO response = new ResponseDTO();

                List<DayDTO> selectedMonth = await GenerateMonth(request.filter.year, request.filter.month);
                response.Data = selectedMonth;
                return response;
            }
            catch (Exception ex)
            {
                //return GenericExceptionResult(ex);
                return null;
            }
        }

        private async Task<List<DayDTO>> GenerateMonth(int year, int month)
        {
            var days = new List<DayDTO>();
            int totalDays = DateTime.DaysInMonth(year, month);

            List<HolidayDTO> holidays = await _HolidayService.GetHolidaysAsync(year, "CR");
            //obtener las tareas del mes para asignarlas a cada dia

            for (int i = 1; i <= totalDays; i++)
            {
                var date = new DateTime(year, month, i);
                var holiday = holidays.FirstOrDefault(h => h.Date.Date == date.Date);

                days.Add(new DayDTO
                {
                    Date = date,
                    WeekDay = date.DayOfWeek,
                    HolidayName = holiday?.LocalName,
                    assigments = new List<AssigmentDTO>()
                });
            }

            return days;
        }

    }
}
