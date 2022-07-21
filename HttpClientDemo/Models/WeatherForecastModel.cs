using System.Text.Json.Serialization;

namespace HttpClientDemo.Models;

public class WeatherForecastModel
{
    public string countryabbreviation { get; set; }
    public Place[] places { get; set; }
    public string country { get; set; }
    public string placename { get; set; }
    public string state { get; set; }
    public string stateabbreviation { get; set; }
}

public class Place
{
    [JsonPropertyName("place name")]
    public string placename { get; set; }
    public string longitude { get; set; }
    [JsonPropertyName("post code")]
    public string postcode { get; set; }
    public string latitude { get; set; }
}
