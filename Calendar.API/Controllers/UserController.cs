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
        public ResponseDTO GetUserById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut]
        public ResponseDTO InsertUser([FromBody] UserDTO user)
        {
            return _service.InsertUser(user);
        }
    }
}
