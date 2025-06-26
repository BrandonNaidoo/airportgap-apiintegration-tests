using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal class FavoritesResponse
    {
        [JsonPropertyName("data")]
        public FavoriteData Data { get; set; } = default!;
    }
}
