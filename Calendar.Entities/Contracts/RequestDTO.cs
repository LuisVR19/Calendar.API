namespace Calendar.Entities.Contracts
{
    public class RequestDTO<TFilter>
    {
        public TFilter filter { get; set; }

        public Object data { get; set; }
    }
}
