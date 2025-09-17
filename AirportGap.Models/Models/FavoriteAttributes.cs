#pragma warning disable CS8618 // Non-nullable property is uninitialized
using System.Text.Json.Serialization;

namespace AirportGap.Models.Models
{
    public sealed class FavoriteAttributes
    {
        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("airport")]
        public FavoriteAirport Airport { get; set; }
    }
}
