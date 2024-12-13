using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private const string ApiKey = "YOUR_OPENWEATHER_API_KEY";
        private const string ApiUrl = "https://api.openweathermap.org/data/2.5/weather";

        public async Task<WeatherResponse> GetWeatherDataAsync(string city)
        {
            using var client = new HttpClient();
            var url = $"{ApiUrl}?q={city}&appid={ApiKey}&units=metric";
            var response = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<WeatherResponse>(response);
        }

        public WeatherData ConvertToWeatherData(WeatherResponse response)
        {
            var temperature = response.Main.Temp.ToString("0.0") + "°C";
            var description = response.Weather[0].Description;
            var iconUrl = $"http://openweathermap.org/img/wn/{response.Weather[0].Icon}.png";

            return new WeatherData(temperature, description, iconUrl);
        }
    }
}
