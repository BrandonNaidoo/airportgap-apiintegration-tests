#pragma warning disable CS8618 // Non-nullable property is uninitialized
using System.Text.Json.Serialization;

namespace AirportGap.Models.Models
{
    public sealed class AirportsResponse
    {
        [JsonPropertyName("data")]
        public List<Airport> Data { get; set; }

        [JsonPropertyName("links")]
        public Dictionary<string, string> Links { get; set; }
    }
}
