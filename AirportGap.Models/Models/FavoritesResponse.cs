#pragma warning disable CS8618 // Non-nullable property is uninitialized
using System.Text.Json.Serialization;

namespace AirportGap.Models.Models
{
    public sealed class FavoritesResponse
    {
        [JsonPropertyName("data")]
        public FavoriteData Data { get; set; }
    }
}
