using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;
using Calendar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _service;
        public UserController(IUserServices service) 
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetUserById")]
        public ResponseDTO GetUserById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        [Route("InsertUser")]
        public ResponseDTO InsertUser(RequestDTO<BaseFilterDTO, UserDTO> request)
        {
            return _service.InsertUser(request);
        }
    }
}
