using System.Net;

using RestAssured.IntegrationTests.Framework;
using RestAssured.IntegrationTests.Models;

using static RestAssured.Dsl;

namespace RestAssured.IntegrationTests.Tests;

internal class PostFavoriteTests : Testbase
{
    [SetUp]
    public void SetupFavorites()
    {
        ClearAllFavorites();
    }

    [Test]
    public void GivenValidAirportId_WhenAddFavorite_ThenReturnsFavoriteData()
    {

        string airportId = "JFK";
        var formdata = new Dictionary<string, string>
        {
            { "note", faker.Random.Words(3)  }
        };

        var jsonSchema = NJsonSchema.JsonSchema.FromType<FavoritesResponse>();

        Given()
          .Spec(authRequestSpecification)
          .ContentType("application/x-www-form-urlencoded")
          .QueryParam("airport_id", airportId)
          .FormData(formdata)
        .When()
          .Post(Endpoints.Favorites)
        .Then()
          .StatusCode(HttpStatusCode.Created)
          .And()
          .MatchesJsonSchema(jsonSchema)
          .And()
          .Body("$", NHamcrest.Is.NotNull())
          .And()
          .Body("$.data", NHamcrest.Is.NotNull());
    }

    public void ClearAllFavorites()
    {
        Given()
          .Spec(authRequestSpecification)
        .When()
          .Delete(Endpoints.ClearAll)
        .Then()
          .StatusCode(HttpStatusCode.NoContent);
    }

}
