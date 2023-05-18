using AutoMapper;
using CalculationCash.Application.Service.Command;
using CalculationCash.Application.ServiceApiCurrency;
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
        private readonly IMediator _mediator;

        public GetEURCurrencyByDateQueryHandler(IRepository<Currency> currencyRepository, IMapper mapper, IMediator mediator)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<CurrencyDto> Handle(GetEURCurrencyByDateQuery request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByDate(request.EffectiveDate);
            if (currency == null) {
               var addCurrency = await _mediator.Send(_mapper.Map<CreateEURCurrencyByDateCommand>(request.EffectiveDate));
                return await Task.FromResult(_mapper.Map<CurrencyDto>(addCurrency));
            }

            return await Task.FromResult(_mapper.Map<CurrencyDto>(currency));

        }
    }
}
