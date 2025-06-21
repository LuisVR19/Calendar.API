using Calendar.Entities.Contracts;

namespace Calendar.Services.Bases
{
    public class BaseService
    {
        public ResponseDTO GenericExceptionResult(Exception ex)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSucceded = false;
            response.Message = ex.Message;
            return response;
        }
    }
}
