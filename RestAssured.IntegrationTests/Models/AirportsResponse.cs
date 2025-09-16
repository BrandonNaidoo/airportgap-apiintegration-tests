using System.Text.Json.Serialization;

namespace RestAssured.IntegrationTests.Models
{
    internal sealed class AirportsResponse
    {
        [JsonPropertyName("data")]
        public List<Airport> Data { get; set; }

        [JsonPropertyName("links")]
        public Dictionary<string, string> Links { get; set; }
    }
}
