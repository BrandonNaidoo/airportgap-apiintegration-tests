using IntegrationTests.Models;

namespace IntegrationTests.Framework.Services
{
    internal static class AirportService
    {
        public static async Task<AirportsResponse> GetAirportsAsync(AirportGapClient client)
        {
            var response = await client.GetAsync<AirportsResponse>(Endpoints.Airports).ConfigureAwait(false);
            return response!;
        }

        public static async Task<FavoritesResponse> AddFavoriteAsync(AirportGapClient client, string airportId, string? note = null)
        {
            var uri = Endpoints.AddFavorite(airportId, note);
            var response = await client.PostAsync<FavoritesResponse>(uri).ConfigureAwait(false);
            return response!;
        }

        public static async Task ClearFavoritesAsync(AirportGapClient client)
        {
            var uri = Endpoints.ClearFavorites();
            await client.DeleteAsync(uri).ConfigureAwait(false);
        }

    }
}
