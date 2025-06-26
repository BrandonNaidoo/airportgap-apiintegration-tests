using System.Net.Http.Headers;

namespace IntegrationTests.Framework
{
    internal static class HttpClientFactory
    {
        public static HttpClient Create(bool authenticated = false)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://airportgap.com/api/")
            };

            if (authenticated)
            {
                var token = Environment.GetEnvironmentVariable("AIRPORT_GAP_API_TOKEN");
                if (string.IsNullOrWhiteSpace(token))
                {
                    throw new InvalidOperationException("Missing AIRPORT_GAP_API_TOKEN environment variable");
                }

                client.DefaultRequestHeaders.Authorization =
                  new AuthenticationHeaderValue("Token", token);
            }

            return client;
        }
    }
}
