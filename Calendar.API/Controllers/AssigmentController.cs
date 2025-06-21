using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssigmentController : ControllerBase
    {
        [HttpPost]
        public ResponseDTO CreateAssigment(RequestDTO<BaseFilterDTO> request)
        {
            return null;
        }

        [HttpPut]
        public ResponseDTO UpdateAssigment(RequestDTO<BaseFilterDTO> request)
        {
            return null;
        }

    }
}
