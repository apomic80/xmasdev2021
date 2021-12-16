using blzcomponents.Models;
using blzcomponents.Services;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blzwinforms.Services
{
    public class DataService : IDataService
    {
        public Task<WeatherForecast[]> GetForecastAsync()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName); ;
                return Task.FromResult(JsonSerializer.Deserialize<WeatherForecast[]>(json));
            }
            else return Task.FromResult(new WeatherForecast[0]);
        }
    }
}