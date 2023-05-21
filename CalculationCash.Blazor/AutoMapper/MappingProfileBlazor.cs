using AutoMapper;
using CalculationCash.Application.Service.Command;
using CalculationCash.Application;
using CalculationCash.Domain.Model;

namespace CalculationCash.Blazor
{
    public class MappingProfileBlazor : Profile
    {
        public MappingProfileBlazor()
        {
            CreateMap<ConvertedTransactionBlazor, ConvertedTransactionDto>().ReverseMap();
            CreateMap<CurrencyBlazor, CurrencyDto>().ReverseMap();
            CreateMap<ReportAfterConversionBlazor, ReportAfterConversionDto>().ReverseMap();
            CreateMap<ReportBeforeConversionBlazor, ReportBeforeConversionDto>().ReverseMap();
            CreateMap<TransactionBlazor, TransactionDto>().ReverseMap();

            //CreateMap<>().ReverseMap();
        }
    }
}
