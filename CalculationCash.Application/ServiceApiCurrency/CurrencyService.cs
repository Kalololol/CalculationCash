using Newtonsoft.Json;

namespace CalculationCash.Application.ServiceApiCurrency
{
    public interface ICurrencyService
    {
        Task<CurrencyDto> GetEURCurrencyByDate(DateTime date);
        Task<CurrencyDto> GetUSDCurrencyByDate(DateTime date);

    }
    public class CurrencyService : ICurrencyService
    {
        HttpClient client = new HttpClient();

        public async Task<CurrencyDto?> GetEURCurrencyByDate(DateTime date)
        {
            try
            {
                string dateToApi = date.ToString("yyyy-MM-dd");
                string url = "http://api.nbp.pl/api/exchangerates/rates/a/eur/" + dateToApi + "/";
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
            // obsługa błędów
            catch (HttpRequestException ex)
            {
                //błędy API
                Console.Out.WriteLine("Błąd połączenia z API: " + ex.Message);
                return null;
            }
            catch(JsonException ex)
            {
                // błędy związane z niepoprawnym formatem JSON
                Console.Out.WriteLine("Błąd podczas odczytu danych z API: " + ex.Message);
                return null;
            }
            catch(Exception ex)
            {
                // wszystkie pozostałe błędy
                Console.WriteLine("Nieznany błąd: " + ex.Message);
                return null;
            }
        }

        public async Task<CurrencyDto?> GetUSDCurrencyByDate(DateTime date)
        {
            try { 
            string dateToApi = date.ToString("yyyy-MM-dd");
            string url = "http://api.nbp.pl/api/exchangerates/rates/a/usd/" + dateToApi + "/"; 
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
            // obsługa błędów
            catch (HttpRequestException ex)
            {
                //błędy API
                Console.Out.WriteLine("Błąd połączenia z API: " + ex.Message);
                return null;
            }
            catch(JsonException ex)
            {
                // błędy związane z niepoprawnym formatem JSON
                Console.Out.WriteLine("Błąd podczas odczytu danych z API: " + ex.Message);
                return null;
            }
            catch(Exception ex)
            {
                // wszystkie pozostałe błędy
                Console.WriteLine("Nieznany błąd: " + ex.Message);
                return null;
            }
        }
    }
    
}