using FluentAssertions;

using IntegrationTests.Framework.Services;
using IntegrationTests.Models;

namespace IntegrationTests.Tests
{
    [TestFixture]
    public class GetAirportsTests : TestBase
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
