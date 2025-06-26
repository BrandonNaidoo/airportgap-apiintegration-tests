using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal class Airport
    {
        [JsonPropertyName("id")]
        public required string Id { get; set; }

        [JsonPropertyName("type")]
        public required string Type { get; set; }

        [JsonPropertyName("attributes")]
        public required AirportAttributes Attributes { get; set; }
    }
}
