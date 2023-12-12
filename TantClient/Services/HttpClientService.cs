using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TantClient.Services
{
    public class HttpClientService
    {
        private const string BaseApiUrl = "https://tant.belofflab.com/api/v1";
        protected readonly HttpClient _httpClient;
        public HttpClientService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseApiUrl);
        }
        public async Task<string> GetAsync(string url)
        {
            try {
                return await _httpClient.GetStringAsync(_httpClient.BaseAddress + url);
            } catch {
                return null;
            }
        }
        public async Task<string> PostAsync(string url, string jsonContent)
        {
            try {
                HttpResponseMessage response = await _httpClient.PostAsync(_httpClient.BaseAddress + url, new StringContent(jsonContent, Encoding.UTF8, "application/json"));
                return await response.Content.ReadAsStringAsync();
            }catch { return null; }
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
