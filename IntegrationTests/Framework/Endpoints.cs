namespace IntegrationTests.Framework
{
    internal static class Endpoints
    {
        public static readonly Uri Airports = new("airports", UriKind.Relative);
        public static Uri AddFavorite(string airportId, string? note = null)
        {
            var query = $"favorites?airport_id={Uri.EscapeDataString(airportId)}";

            if (!string.IsNullOrWhiteSpace(note))
            {
                query += $"&note={Uri.EscapeDataString(note)}";
            }

            return new Uri(query, UriKind.Relative);
        }
        public static Uri ClearFavorites() => new Uri("favorites/clear_all", UriKind.Relative);
    }
}
