using AutoMapper;
using CalculationCash.Application.ServiceApiCurrency;
using CalculationCash.Data;
using CalculationCash.Domain.Model;
using MediatR;

namespace CalculationCash.Application.Service.Command
{
    public class CreateEURCurrencyByDateCommand : IRequest<Unit>
    {        
        public DateTime EffectiveDate { get; set; }

        public CreateEURCurrencyByDateCommand(DateTime effectiveDate)
        {
            EffectiveDate = effectiveDate;
        }
    }

    public class CreateEURCurrencyByDateCommandHandler : IRequestHandler<CreateEURCurrencyByDateCommand, Unit>
    {
        private readonly IRepository<Currency> _currencyRepository;
        private readonly IMapper _mapper;
        private readonly ICurrencyService _currencyService;

        public CreateEURCurrencyByDateCommandHandler(IRepository<Currency> currencyRepository, IMapper mapper, ICurrencyService currencyService)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
            _currencyService = currencyService;
        }

        public Task<Unit> Handle(CreateEURCurrencyByDateCommand request, CancellationToken cancellationToken)
        {
            var currency = _currencyService.GetEURCurrencyByDate(request.EffectiveDate);
            _currencyRepository.Add(_mapper.Map<Currency>(currency));

            return Task.FromResult(Unit.Value);
        }


    }
}
