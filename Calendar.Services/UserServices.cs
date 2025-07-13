using Calendar.Data.Interfaces;
using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;
using Calendar.Services.Interfaces;

namespace Calendar.Services
{
    public class UserServices : IUserServices
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
                return null;
            }
        }

        public ResponseDTO InsertUser(RequestDTO<BaseFilterDTO, UserDTO> request)
        {
            try
            {
                ResponseDTO response = new ResponseDTO();
                UserDTO user = (UserDTO)request.data;

                if (_repository.ExistsUser(user))
                {
                    response.Message = "El usuario ingresado ya existe.";
                    response.IsSucceded = false;
                    return response;
                }

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
                return null;
                //return GenericExceptionResult(ex);
            }
        }
    }
}
