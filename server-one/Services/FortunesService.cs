using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace server_one
{
    public class FortunesService
    {
        private readonly Uri _apiUri;
        private readonly HttpClient _client;

        public FortunesService(string apiUrl)
        {
            _apiUri = new Uri(apiUrl);
            
            _client = new HttpClient();
            _client.BaseAddress = _apiUri;
        }

        public async Task<string> GetRandomFortune()
        {
            var fortune = await (await _client.GetAsync("random")).Content.ReadAsStringAsync();

            return fortune;
        }
    }
}