using Bogus;

using IntegrationTests.Framework;

namespace IntegrationTests.Tests
{
    public abstract class TestBase
    {
        public AirportGapClient Client { get; private set; }
        public Faker faker;


        public virtual bool UseAuthenticatedClient => false;

        [OneTimeSetUp]
        public void Setup()
        {
            var httpClient = HttpClientFactory.Create(UseAuthenticatedClient);
            Client = new AirportGapClient(httpClient);
            faker = new Faker();
        }
    }
}
