using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace marvel_web
{
    public class CharacterClient
    {
        private readonly HttpClient _client;

        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        public CharacterClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Character[]> GetCharactersAsync()
        {
            var response = await _client.GetAsync("/characters");
            var stream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Character[]>(stream, options);
        }
    }
}