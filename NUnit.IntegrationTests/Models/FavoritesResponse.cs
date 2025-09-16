using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal sealed class FavoritesResponse
    {
        [JsonPropertyName("data")]
        public FavoriteData Data { get; set; }
    }
}
