using AutoMapper;

namespace CalculationCash.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static IMapper Initialize()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
