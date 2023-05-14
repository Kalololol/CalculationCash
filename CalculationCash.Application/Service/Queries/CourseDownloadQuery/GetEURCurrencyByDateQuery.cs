using AutoMapper;
using CalculationCash.Data;
using CalculationCash.Domain.Model;
using MediatR;

namespace CalculationCash.Application.Service
{
    public class GetEURCurrencyByDateQuery : IRequest<CurrencyDto>
    {
        public DateTime EffectiveDate { get; set; }

        public GetEURCurrencyByDateQuery(DateTime effectiveDate)
        {
            EffectiveDate = effectiveDate;
        }
    }
    public class GetEURCurrencyByDateQueryHandler : IRequestHandler<GetEURCurrencyByDateQuery, CurrencyDto>
    {
        private readonly IRepository<Currency> _currencyRepository;
        private readonly IMapper _mapper;

        public GetEURCurrencyByDateQueryHandler(IRepository<Currency> currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }

        public Task<CurrencyDto> Handle(GetEURCurrencyByDateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
