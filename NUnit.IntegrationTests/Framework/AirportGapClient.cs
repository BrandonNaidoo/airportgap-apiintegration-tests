using System.Text;
using System.Text.Json;

namespace IntegrationTests.Framework
{
    public class AirportGapClient
    {
        private readonly HttpClient _client;

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        internal AirportGapClient(HttpClient client)
        {
            _client = client;
        }

        internal async Task<T?> GetAsync<T>(Uri endpoint)
        {
            var response = await _client.GetAsync(endpoint).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(json, JsonOptions);
        }
        internal async Task<T?> PatchAsync<T>(Uri endpoint)
        {
            var response = await _client.PatchAsync(endpoint, null).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(json, JsonOptions);
        }

        internal async Task<T?> PostAsync<T>(Uri endpoint, object requestBody)
        {
            using var jsonContent = new StringContent(
              JsonSerializer.Serialize(requestBody, JsonOptions),
              Encoding.UTF8,
              "application/json");

            var response = await _client.PostAsync(endpoint, jsonContent).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(json, JsonOptions);
        }

        internal async Task<T?> PostAsync<T>(Uri endpoint)
        {
            var response = await _client.PostAsync(endpoint, null).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(json, JsonOptions);
        }

        internal async Task<T?> PutAsync<T>(Uri endpoint, object requestBody)
        {
            using var jsonContent = new StringContent(
              JsonSerializer.Serialize(requestBody, JsonOptions),
              Encoding.UTF8,
              "application/json");

            var response = await _client.PutAsync(endpoint, jsonContent).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(json, JsonOptions);
        }

        internal async Task DeleteAsync(Uri endpoint)
        {
            var response = await _client.DeleteAsync(endpoint).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}
