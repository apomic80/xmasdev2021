using blzcomponents.Models;

namespace blzcomponents.Services
{
    public interface IDataService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}