using FluentAssertions;

using IntegrationTests.Framework.Services;
using IntegrationTests.Tests;

namespace Integration_Tests.Tests;
internal sealed class PatchFavoritesTests : TestBase
{
    public override bool UseAuthenticatedClient => true;

    [SetUp]
    public async Task SetupFavorites()
    {
        await AirportService.ClearFavoritesAsync(Client).ConfigureAwait(false);
    }

    [Test]
    public async Task GivenAnExistingFavorite_WhenUpdateFavorite_ThenSuccess()
    {
        // Arrange
        string favoriteId = await AddFavorite().ConfigureAwait(false);
        string updatedNote = faker.Random.Words(3);

        // Act
        var response = await AirportService.UpdateFavoriteAsync(Client, favoriteId, updatedNote).ConfigureAwait(false);

        response.Data.Attributes.Note.Should().Be(updatedNote);
    }

    public async Task<string> AddFavorite()
    {
        const string airportId = "JFK";
        string note = faker.Random.Words(3);

        var response = await AirportService.AddFavoriteAsync(Client, airportId, note).ConfigureAwait(false);

        return response.Data.Id;


    }

}
