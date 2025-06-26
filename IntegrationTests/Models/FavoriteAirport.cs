using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal class FavoriteAirport
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        [JsonPropertyName("city")]
        public string City { get; set; } = default!;

        [JsonPropertyName("country")]
        public string Country { get; set; } = default!;

        [JsonPropertyName("iata")]
        public string Iata { get; set; } = default!;

        [JsonPropertyName("icao")]
        public string Icao { get; set; } = default!;

        [JsonPropertyName("latitude")]
        public string Latitude { get; set; } = default!;

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; } = default!;

        [JsonPropertyName("altitude")]
        public int Altitude { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; } = default!;
    }
}
