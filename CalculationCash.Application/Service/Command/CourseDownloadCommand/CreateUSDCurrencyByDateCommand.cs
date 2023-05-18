using AutoMapper;
using CalculationCash.Application.ServiceApiCurrency;
using CalculationCash.Data;
using CalculationCash.Domain.Model;
using MediatR;

namespace CalculationCash.Application.Service.Command
{
    public class CreateUSDCurrencyByDateCommand : IRequest<Unit>
    {
        public DateTime EffectiveDate { get; set; }

        public CreateUSDCurrencyByDateCommand(DateTime effectiveDate)
        {
            EffectiveDate = effectiveDate;
        }
    }

    public class CreateUSDCurrencyByDateCommandHandler : IRequestHandler<CreateUSDCurrencyByDateCommand, Unit>
    {
        private readonly IRepository<Currency> _currencyRepository;
        private readonly IMapper _mapper;
        private readonly ICurrencyService _currencyService;

        public CreateUSDCurrencyByDateCommandHandler(IRepository<Currency> currencyRepository, IMapper mapper, ICurrencyService currencyService)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
            _currencyService = currencyService;
        }

        public Task<Unit> Handle(CreateUSDCurrencyByDateCommand request, CancellationToken cancellationToken)
        {
            var currency = _currencyService.GetUSDCurrencyByDate(request.EffectiveDate);
            _currencyRepository.Add(_mapper.Map<Currency>(currency));

            return Task.FromResult(Unit.Value);
        }


    }
}
