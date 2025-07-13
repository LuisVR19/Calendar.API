namespace Calendar.Entities.Contracts
{
    public class RequestDTO<TFilter, TData>
    {
        public TFilter filter { get; set; }

        public TData data { get; set; }
    }
}
