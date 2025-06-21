using AutoMapper;

namespace Calendar.Data.Mapper
{
    public static class AutoMapperHelper
    {
        private static IMapper _mapper;

        static AutoMapperHelper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            _mapper = config.CreateMapper();
        }

        public static TDestino Map<TOrigen, TDestino>(TOrigen origen)
        {
            return _mapper.Map<TDestino>(origen);
        }
    }
}
