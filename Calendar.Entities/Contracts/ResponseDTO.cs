namespace Calendar.Entities.Contracts
{
    public class ResponseDTO
    {
        public bool IsSucceded { get; set; } = true;
        public string Message { get; set; }
        public Object Data { get; set; }
    }
}
