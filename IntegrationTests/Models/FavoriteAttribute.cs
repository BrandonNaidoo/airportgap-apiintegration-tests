using System.Text.Json.Serialization;

namespace IntegrationTests.Models
{
    internal class FavoriteAttributes
    {
        [JsonPropertyName("note")]
        public string Note { get; set; } = default!;

        [JsonPropertyName("airport")]
        public FavoriteAirport Airport { get; set; } = default!;
    }
}
