using blzcomponents.Services;
using blzcomponents.Models;
using System.Net.Http.Json;

namespace blzwasm.Client.Services
{
    public class DataService : IDataService
    {
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<WeatherForecast[]> GetForecastAsync()
        {
            return _httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}