using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DotNetdit.Utilities;

namespace DotNetdit.Web
{
    internal class WebAgent : IWebAgent
    {
        private readonly HttpClient _client;

        public WebAgent(string baseAddress) {
            baseAddress.ThrowIfNull("baseAddress");

            _client = new HttpClient {
                BaseAddress = new Uri(baseAddress)
            };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> PerformGetAsync(string uri) {
            uri.ThrowIfNull("uri");

            var response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}
