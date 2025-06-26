using IntegrationTests.Framework;

namespace IntegrationTests.Tests
{
    public abstract class TestBase
    {
        public AirportGapClient Client { get; private set; }

        public virtual bool UseAuthenticatedClient => false;

        [SetUp]
        public void Setup()
        {
            var httpClient = HttpClientFactory.Create(UseAuthenticatedClient);
            Client = new AirportGapClient(httpClient);
        }
    }
}
