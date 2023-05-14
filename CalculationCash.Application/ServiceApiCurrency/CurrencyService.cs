using Newtonsoft.Json;

namespace CalculationCash.Application.ServiceApiCurrency
{
    public class CurrencyService : ICurrencyService
    {
        HttpClient client = new HttpClient();

        public async Task<CurrencyDto> GetCurrencyByDate(DateTime date)
        {
            //prawdopodobnie trzeba będzie przeformatować date na string tak aby poprawnie dodawała się do adresu API
            string url = "http://api.nbp.pl/api/exchangerates/rates/a/eur/" + date + "/"; // data powinna być w formacie RRRR-mm-DD
            HttpResponseMessage response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            dynamic obj = JsonConvert.DeserializeObject(responseBody);

            CurrencyDto dto = new CurrencyDto()
            {
                CurrencyName = obj.currency,
                Code = obj.code,
                EffectiveDate = DateTime.Parse((obj.rates[0].effectiveDate).ToString()),
                Mid = decimal.Parse((obj.rates[0].mid).ToString())
            };

            return await Task.FromResult(dto);

        }
    }
}

/* public string CurrencyName { get; set; }
        public string Code { get; set; }
        public decimal Mid { get; set; }
        public DateTime EffectiveDate { get; set; }*/
