using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
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

        //[HttpGet]
        //public ResponseDTO Login(string email, string password)
        //{
        //    return null;
        //}

        //[HttpPost]
        //public ResponseDTO Register(RequestDTO<BaseFilterDTO> request)
        //{
        //    return null;
        //}
    }
}
