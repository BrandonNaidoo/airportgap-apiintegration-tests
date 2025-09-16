using System.Text.Json.Serialization;

namespace RestAssured.IntegrationTests.Models
{
    internal sealed class FavoriteData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public FavoriteAttributes Attributes { get; set; }
    }
}
