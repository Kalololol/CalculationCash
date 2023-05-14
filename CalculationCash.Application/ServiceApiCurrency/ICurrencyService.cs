namespace CalculationCash.Application.ServiceApiCurrency
{
    public interface ICurrencyService
    {
        Task <CurrencyDto> GetCurrencyByDate(DateTime date);
    }
}
