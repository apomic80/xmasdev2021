using blzcomponents.Models;
using blzcomponents.Services;
using Microsoft.Win32;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace blzwpf.Services
{
    public class DataService : IDataService
    {
        public Task<WeatherForecast[]> GetForecastAsync()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                string json = File.ReadAllText(openFileDialog.FileName); ;
                return Task.FromResult(JsonSerializer.Deserialize<WeatherForecast[]>(json));
            }
            else return Task.FromResult(new WeatherForecast[0]);
        }
    }
}