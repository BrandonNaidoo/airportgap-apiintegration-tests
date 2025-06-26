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
                
                if (!string.IsNullOrEmpty(token))
                {
                    var preview = token.Length >= 4 ? token.Substring(0, 4) : token;
                    Console.WriteLine($"Token starts with: {preview}");
                }
                else
                {
                    Console.WriteLine("Token is null or empty");
                }

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
