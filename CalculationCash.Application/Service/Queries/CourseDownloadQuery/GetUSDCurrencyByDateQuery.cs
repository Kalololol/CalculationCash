using AutoMapper;
using CalculationCash.Application.Service.Command;
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
        private readonly IMediator _mediator;

        public GetUSDCurrencyByDateQueryHandler(IRepository<Currency> currencyRepository, IMapper mapper, IMediator mediator)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<CurrencyDto> Handle(GetUSDCurrencyByDateQuery request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByDate(request.EffectiveDate);
            if (currency == null)
            {
                var addCurrency = await _mediator.Send(_mapper.Map<CreateUSDCurrencyByDateCommand>(request.EffectiveDate));
                return await Task.FromResult(_mapper.Map<CurrencyDto>(addCurrency));
            }

            return await Task.FromResult(_mapper.Map<CurrencyDto>(currency));
        }
    }
}
