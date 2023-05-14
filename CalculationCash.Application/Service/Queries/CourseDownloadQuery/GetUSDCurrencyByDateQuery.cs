using AutoMapper;
using CalculationCash.Data;
using CalculationCash.Domain.Model;
using MediatR;

namespace CalculationCash.Application.Service
{
    public class GetUSDCurrencyByDateQuery : IRequest<CurrencyDto>
    {
        public DateTime EffectiveDate { get; set; }

        public GetUSDCurrencyByDateQuery(DateTime effectiveDate)
        {
            EffectiveDate = effectiveDate;
        }
    }
    public class GetUSDCurrencyByDateQueryHandler : IRequestHandler<GetUSDCurrencyByDateQuery, CurrencyDto>
    {
        private readonly IRepository<Currency> _currencyRepository;
        private readonly IMapper _mapper;

        public GetUSDCurrencyByDateQueryHandler(IRepository<Currency> currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }

        public Task<CurrencyDto> Handle(GetUSDCurrencyByDateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
