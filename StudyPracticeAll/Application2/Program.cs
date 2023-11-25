namespace Application2;

using System.Net;
using Newtonsoft.Json;

public class Program
{
    static string apiKey = "27ccba42af82dcfd24632f5db1ad0c78";
    static string defaultCity = "Томск";

    public static void Main(string[] args)
    {
        GetWeather(defaultCity);

        Console.WriteLine("Введите название города для получения погоды:");
        string city = Console.ReadLine();

        GetWeather(city);
    }

    private static void GetWeather(string city)
    {
        string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";

        using (WebClient client = new WebClient())
        {
            string json = client.DownloadString(url);
            WeatherData weather = JsonConvert.DeserializeObject<WeatherData>(json);
            Console.WriteLine($"Погода в городе {weather.name}: {weather.weather[0].description}");
            Console.WriteLine($"Температура: {weather.main.temp}°C");
        }
    }
}

class WeatherData
{
    public string name { get; set; }
    public Weather[] weather { get; set; }
    public Main main { get; set; }
}

class Weather
{
    public string description { get; set; }
}

class Main
{
    public float temp { get; set; }
}