using WeatherApp.Models;
using WeatherApp.Services;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace WeatherApp.ViewModels
{
    public class WeatherViewModel : BindableObject
    {
        private string _temperature;
        private string _weatherDescription;
        private string _iconUrl;

        public string Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                OnPropertyChanged();
            }
        }

        public string WeatherDescription
        {
            get => _weatherDescription;
            set
            {
                _weatherDescription = value;
                OnPropertyChanged();
            }
        }

        public string IconUrl
        {
            get => _iconUrl;
            set
            {
                _iconUrl = value;
                OnPropertyChanged();
            }
        }

        public async Task GetWeather(string city)
        {
            var weatherService = new WeatherService();
            var weatherResponse = await weatherService.GetWeatherDataAsync(city);

            var weatherData = weatherService.ConvertToWeatherData(weatherResponse);

            Temperature = weatherData.Temperature;
            WeatherDescription = weatherData.WeatherDescription;
            IconUrl = weatherData.IconUrl;
        }
    }
}
