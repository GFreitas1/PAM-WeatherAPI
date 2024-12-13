namespace WeatherApp.Models
{
    public class WeatherData
    {
        public string Temperature { get; set; }
        public string WeatherDescription { get; set; }
        public string IconUrl { get; set; }

        public WeatherData(string temperature, string weatherDescription, string iconUrl)
        {
            Temperature = temperature;
            WeatherDescription = weatherDescription;
            IconUrl = iconUrl;
        }
    }
}
