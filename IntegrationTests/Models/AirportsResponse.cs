using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal class AirportsResponse
    {
        [JsonPropertyName("data")]
        public required List<Airport> Data { get; set; }

        [JsonPropertyName("links")]
        public required Dictionary<string, string> Links { get; set; }
    }
}
