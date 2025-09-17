using AirportGap.Models.Models;

using FluentAssertions;

using IntegrationTests.Framework.Services;

namespace IntegrationTests.Tests
{
    [TestFixture]
    internal sealed class PostFavoriteTests : TestBase
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
            string note = faker.Random.Words(3);

            // Act
            var response = await AirportService.AddFavoriteAsync(Client, airportId, note).ConfigureAwait(false);

            // Assert
            response.Should().NotBeNull();
            response.Should().BeOfType<FavoritesResponse>();
            response.Data.Should().NotBeNull();
        }
    }
}
