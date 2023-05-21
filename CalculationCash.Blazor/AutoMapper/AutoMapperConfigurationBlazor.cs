using AutoMapper;

namespace CalculationCash.Blazor
{
    public class AutoMapperConfigurationBlazor
    {
        public static IMapper Initialize()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfileBlazor>();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
