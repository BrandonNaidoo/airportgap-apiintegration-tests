using FluentAssertions;
using IntegrationTests.Framework.Services;
using IntegrationTests.Models;

namespace IntegrationTests.Tests
{
    [TestFixture]
    public class FavoritesTests : TestBase
    {
        public override bool UseAuthenticatedClient => true;

        [SetUp]
        public async Task SetupFavorites()
        {
            await AirportService.ClearFavoritesAsync(Client).ConfigureAwait(false);
        }

        [Test]
        public async Task GivenValidAirportId_WhenAddFavorite_ThenReturnsFavoriteData()
        {
            // Arrange
            const string airportId = "JFK"; 

            // Act
            var response = await AirportService.AddFavoriteAsync(Client, airportId).ConfigureAwait(false);

            // Assert
            response.Should().NotBeNull();
            response.Should().BeOfType<FavoritesResponse>();
            response.Data.Should().NotBeNull();
        }
    }
}
