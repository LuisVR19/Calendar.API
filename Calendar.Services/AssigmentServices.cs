using Calendar.Data.Interfaces;
using Calendar.Entities.Contracts;
using Calendar.Entities.Contracts.Filters;
using Calendar.Entities.DTOs;
using Calendar.Services.Interfaces;

namespace Calendar.Services
{
    public class AssigmentServices : IAssigmentServices
    {
        private readonly IAssigmentRepository _repository;

        public AssigmentServices(IAssigmentRepository repository)
        {
            _repository = repository;
        }

        public ResponseDTO InsertAssigment(RequestDTO<BaseFilterDTO> request)
        {
            try
            {
                ResponseDTO response = new ResponseDTO();
                AssigmentDTO assigmentDTO = (AssigmentDTO)request.data;
                if (_repository.ExistsAssigment(assigmentDTO))
                {
                    response.Message = "La tarea ingresada ya existe.";
                    response.IsSucceded = false;
                    return response;
                }

                //Encriptar

                if (!_repository.InsertAssigment(assigmentDTO))
                {
                    response.Message = "No se ha podido registrar la tarea. Por favor intentelo de nuevo.";
                    response.IsSucceded = false;
                    return response;
                }

                response.Message = "Tarea registrada exitosamente.";

                return response;
            }
            catch (Exception ex)
            {
                //return GenericExceptionResult(ex);
                return null;
            }
        }
    }
}
