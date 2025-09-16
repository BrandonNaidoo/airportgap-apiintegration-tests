using System.Net;

using RestAssured.IntegrationTests.Framework;
using RestAssured.IntegrationTests.Models;

using static RestAssured.Dsl;

namespace RestAssured.IntegrationTests.Tests
{
    public class GetAirportsTests : Testbase
    {

        [Test]
        public void GivenValidRequest_WhenGetAirports_ThenReturnsListOfAirports()
        {
            var jsonSchema = NJsonSchema.JsonSchema.FromType<AirportsResponse>();

            Given()
                .Spec(unAuthRequestSpecification)
            .When()
                .Get(Endpoints.Airports)
            .Then()
                .StatusCode(HttpStatusCode.OK)
                .And()
                .Body("$", NHamcrest.Is.NotNull())
                .And()
                .MatchesJsonSchema(jsonSchema);
        }
    }
}
