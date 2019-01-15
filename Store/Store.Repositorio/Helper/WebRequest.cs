using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Store.Repositorio.Helper
{
    public sealed class WebRequest
    {
        private WebRequest()
        {
        }

        private readonly HttpClient _httpClient = new HttpClient();

        private static readonly Lazy<WebRequest> _lazy = new Lazy<WebRequest>(() => new WebRequest());
        public static WebRequest Instancia => _lazy.Value;

        public async Task<T> Retornar<T>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var encoded = await response.Content.ReadAsStringAsync();
            }
        }
    }
}