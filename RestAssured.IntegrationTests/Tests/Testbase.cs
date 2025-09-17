using Bogus;

using RestAssured.Logging;
using RestAssured.Request.Builders;

namespace RestAssured.IntegrationTests.Tests
{
    public abstract class Testbase
    {
        public RequestSpecification unAuthRequestSpecification;
        public RequestSpecification authRequestSpecification;
        public Faker faker;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            unAuthRequestSpecification = CreateBaseRequestSpecBuilder()
                .Build();

            string token = "token=" + Environment.GetEnvironmentVariable("AIRPORT_GAP_API_TOKEN");

            if (string.IsNullOrWhiteSpace(token))
            {
                throw new InvalidOperationException("Missing AIRPORT_GAP_API_TOKEN environment variable");
            }

            authRequestSpecification = CreateBaseRequestSpecBuilder()
                .WithOAuth2(token)
                .Build();

            faker = new Faker();
        }

        [SetUp]
        public void Setup()
        {
        }

        private RequestSpecBuilder CreateBaseRequestSpecBuilder()
        {
            LogConfiguration log = new LogConfiguration { RequestLogLevel = RequestLogLevel.All, ResponseLogLevel = ResponseLogLevel.All };

            return new RequestSpecBuilder()
                .WithBaseUri("https://airportgap.com")
                .WithBasePath("/api")
                .WithLogConfiguration(log)
                .WithDisabledSslCertificateValidation();
        }
    }
}
