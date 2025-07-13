using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Calendar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarServices _service;
        public CalendarController(ICalendarServices service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("GetMonthByDate")]
        public Task<ResponseDTO> GetMonthByDate([FromBody] RequestDTO<CalendarFilterDTO, Object> request)
        {
            return _service.GetMonthByDate(request);
        }
    }
}
