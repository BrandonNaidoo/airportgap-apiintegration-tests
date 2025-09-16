using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal sealed class Airport
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public AirportAttributes Attributes { get; set; }
    }
}
