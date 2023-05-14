namespace CalculationCash.Application.ServiceApiCurrency
{
    public interface ICurrencyService
    {
        Task <CurrencyDto> GetEURCurrencyByDate(DateTime date);
        Task<CurrencyDto> GetUSDCurrencyByDate(DateTime date);

    }
}
