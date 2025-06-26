using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal class FavoriteData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        [JsonPropertyName("attributes")]
        public FavoriteAttributes Attributes { get; set; } = default!;
    }
}
