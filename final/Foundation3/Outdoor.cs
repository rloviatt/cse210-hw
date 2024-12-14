public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address, "Outdoor")
    {
        _weatherForecast = weatherForecast;
    }

    public override string DisplayFullDetails()
    {
        return $"{DisplayStandardDetails()}\nType: {_type}\nWeather Forecast: {_weatherForecast}";
    }
}