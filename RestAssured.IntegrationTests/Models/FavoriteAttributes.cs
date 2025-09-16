using System.Text.Json.Serialization;

namespace RestAssured.IntegrationTests.Models
{
    internal sealed class FavoriteAttributes
    {
        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("airport")]
        public FavoriteAirport Airport { get; set; }
    }
}
