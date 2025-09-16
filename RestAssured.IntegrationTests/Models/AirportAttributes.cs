using System.Text.Json.Serialization;

namespace RestAssured.IntegrationTests.Models
{
    internal sealed class AirportAttributes
    {

        [JsonPropertyName("altitude")]
        public int Altitude { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("iata")]
        public string Iata { get; set; }

        [JsonPropertyName("icao")]
        public string Icao { get; set; }

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}
