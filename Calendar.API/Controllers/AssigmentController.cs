using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;
using Calendar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssigmentController : ControllerBase
    {
        private readonly IAssigmentServices _service;
        public AssigmentController(IAssigmentServices service)
        {
            _service = service;
        }

        [HttpPost]
        public ResponseDTO InsertAssigment(RequestDTO<BaseFilterDTO, AssigmentDTO> request)
        {
            return _service.InsertAssigment(request);
        }

        [HttpPut]
        public ResponseDTO UpdateAssigment(RequestDTO<BaseFilterDTO, AssigmentDTO> request)
        {
            return _service.UpdateAssigment(request);
        }

        [HttpPost]
        [Route("GetByUser")]
        public ResponseDTO GetByUser([FromBody] RequestDTO<BaseFilterDTO, Object> request) 
        {
            return _service.GetByUser(request);
        }
    }
}
