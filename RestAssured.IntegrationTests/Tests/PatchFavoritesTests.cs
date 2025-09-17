using System.Net;

using RestAssured.IntegrationTests.Framework;

using static RestAssured.Dsl;

namespace RestAssured.IntegrationTests.Tests
{
    internal class PatchFavoritesTests : Testbase
    {
        [SetUp]
        public void SetupFavorites()
        {
            ClearAllFavorites();
        }

        [Test]
        public void GivenAnExistingFavorite_WhenUpdateFavorite_ThenSuccess()
        {
            string favoriteId = AddFavorite();
            string updatedNote = faker.Random.Words(3);

            var formdata = new Dictionary<string, string>
            {
                { "note", updatedNote }
            };

            Given()
              .Spec(authRequestSpecification)
              .FormData(formdata)
              .PathParam("id", favoriteId)
            .When()
              .Patch(Endpoints.FavoritesById)
            .Then()
              .StatusCode(HttpStatusCode.OK)
              .And()
              .Body("$.data.attributes.note", NHamcrest.Is.EqualTo(updatedNote));
        }

        internal string AddFavorite()
        {
            const string airportId = "KIX";

            var formdata = new Dictionary<string, string>
            {
                { "note", faker.Random.Words(3)  }
            };

            return (string)Given()
                        .Spec(authRequestSpecification)
                        .ContentType("application/x-www-form-urlencoded")
                        .QueryParam("airport_id", airportId)
                        .FormData(formdata)
                      .When()
                        .Post(Endpoints.Favorites)
                      .Then()
                        .StatusCode(HttpStatusCode.Created)
                        .Extract().Body("$.data.id");
        }

        internal void ClearAllFavorites()
        {
            Given()
              .Spec(authRequestSpecification)
            .When()
              .Delete(Endpoints.ClearAll)
            .Then()
              .StatusCode(HttpStatusCode.NoContent);
        }
    }
}
