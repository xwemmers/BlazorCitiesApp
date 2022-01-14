using System.Text.Json.Serialization;

namespace BlazorCitiesApp.Client.Models
{
    public class City
    {
        [JsonPropertyName("CityID")]
        public int CityID { get; set; }
        public string? CityName { get; set; }
        public string? Country { get; set; }
        public int Population { get; set; }
        public int Year { get; set; }
    }
}
