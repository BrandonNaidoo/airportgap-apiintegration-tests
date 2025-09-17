#pragma warning disable CS8618 // Non-nullable property is uninitialized
using System.Text.Json.Serialization;

namespace AirportGap.Models.Models
{
    public sealed class FavoriteData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("attributes")]
        public FavoriteAttributes Attributes { get; set; }
    }
}
