using System;
using System.Net.Http;
using System.Threading.Tasks;
using Store.Utils.Extension;

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
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string encoded = await response.Content.ReadAsStringAsync();
                return encoded.Deserialize<T>();
            }
            return default;
        }
    }
}