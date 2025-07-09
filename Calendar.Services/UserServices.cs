using Calendar.Data.Interfaces;
using Calendar.Entities.Contracts;
using Calendar.Entities.DTOs;
using Calendar.Services.Bases;
using Calendar.Services.Interfaces;

namespace Calendar.Services
{
    public class UserServices : BaseService, IUserServices
    {
        private readonly IUserRepository _repository;
        public UserServices(IUserRepository repository)
        {
            _repository = repository;
        }

        public ResponseDTO GetById(int id)
        {
            try
            {
                ResponseDTO response = new ResponseDTO();

                UserDTO user = _repository.GetUserById(id);
                if (user == null)
                {
                    response.Message = "No se ha encontrado el usuario.";
                    response.IsSucceded = false;
                    return response;
                }
                response.Data = user;
                response.Message = "Usuario obtenido exitosamente.";

                return response;
            }
            catch (Exception ex) {
                return GenericExceptionResult(ex);
            }
        }

        public ResponseDTO InsertUser(UserDTO user)
        {
            try
            {
                ResponseDTO response = new ResponseDTO();

                //Encriptar

                if (!_repository.InsertUser(user))
                {
                    response.Message = "No se ha podido registrar el usuario. Por favor intentelo de nuevo.";
                    response.IsSucceded = false;
                    return response;
                }

                response.Message = "Usuario registrado exitosamente.";

                return response;
            }
            catch (Exception ex)
            {
                return GenericExceptionResult(ex);
            }
        }
    }
}
