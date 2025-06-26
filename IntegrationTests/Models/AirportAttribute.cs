using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal class AirportAttributes
    {

        [JsonPropertyName("altitude")]
        public required int Altitude { get; set; }

        [JsonPropertyName("city")]
        public required string City { get; set; }

        [JsonPropertyName("country")]
        public required string Country { get; set; }

        [JsonPropertyName("iata")]
        public required string Iata { get; set; }

        [JsonPropertyName("icao")]
        public required string Icao { get; set; }

        [JsonPropertyName("latitude")]
        public required string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public required string Longitude { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("timezone")]
        public required string Timezone { get; set; }
    }
}
