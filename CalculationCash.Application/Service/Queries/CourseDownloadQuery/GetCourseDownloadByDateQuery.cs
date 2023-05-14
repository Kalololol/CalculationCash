using AutoMapper;
using CalculationCash.Data;
using CalculationCash.Domain.Model;
using MediatR;

namespace CalculationCash.Application.Service
{
    public class GetCourseDownloadByDateQuery : IRequest<CurrencyDto>
    {
        public DateTime EffectiveDate { get; set; }

        public GetCourseDownloadByDateQuery(DateTime effectiveDate)
        {
            EffectiveDate = effectiveDate;
        }
    }
    public class GetCourseDownloadByDateQueryHandler : IRequestHandler<GetCourseDownloadByDateQuery, CurrencyDto>
    {
        private readonly IRepository<Currency> _currencyRepository;
        private readonly IMapper _mapper;

        public Task<CurrencyDto> Handle(GetCourseDownloadByDateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
