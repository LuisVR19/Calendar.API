using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        [HttpPost]
        public ResponseDTO CreateGroup(RequestDTO<BaseFilterDTO, Object> request)
        {
            return null;
        }

        [HttpPut]
        public ResponseDTO UpdateGroup(RequestDTO<BaseFilterDTO, Object> request)
        {
            return null;
        }
    }
}
