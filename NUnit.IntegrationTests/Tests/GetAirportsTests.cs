using AirportGap.Models.Models;

using FluentAssertions;

using IntegrationTests.Framework.Services;

namespace IntegrationTests.Tests
{
    [TestFixture]
    internal sealed class GetAirportsTests : TestBase
    {
        [Test]
        public async Task GivenValidRequest_WhenGetAirports_ThenReturnsListOfAirports()
        {
            // Act
            var response = await AirportService.GetAirportsAsync(Client).ConfigureAwait(false);

            // Assert
            response.Should().NotBeNull();
            response.Should().BeOfType<AirportsResponse>();
            response.Data.Should().NotBeNullOrEmpty();
            response.Links.Should().NotBeNullOrEmpty();
        }
    }
}
