using AutoMapper;
using CalculationCash.Domain.Model;

namespace CalculationCash.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Currency, CurrencyDto>().ReverseMap();


        }
    }
}
