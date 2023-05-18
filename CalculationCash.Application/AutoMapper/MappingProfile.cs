using AutoMapper;
using CalculationCash.Application.Service.Command;
using CalculationCash.Domain.Model;

namespace CalculationCash.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ConvertedTransaction, ConvertedTransactionDto>().ReverseMap();
            CreateMap<Currency, CurrencyDto>().ReverseMap();
            CreateMap<ReportAfterConversion, ReportAfterConversionDto>().ReverseMap();
            CreateMap<ReportBeforeConversion, ReportBeforeConversionDto>().ReverseMap();
            CreateMap<Transaction, TransactionDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CurrencyDto, CreateEURCurrencyByDateCommand>().ReverseMap();
            //CreateMap<>().ReverseMap();

            

        }
    }
}
