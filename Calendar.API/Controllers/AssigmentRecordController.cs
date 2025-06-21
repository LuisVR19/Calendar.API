using Calendar.Entities.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssigmentRecordController : ControllerBase
    {
        [HttpPut]
        public ResponseDTO SetCompleteStatus()
        {
            return null;
        }
    }
}
