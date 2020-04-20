using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.Services.Implementations
{
    public class WebApiServices
    {
        private readonly HttpClient _httpClient;

        public WebApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Post<t>(t entity, string url)
        {
            HttpClient _httpClient = new HttpClient();

            var uri = "https://localhost:44301/" + url;
            var stringContent = new StringContent(JsonSerializer.Serialize(entity), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync(uri, stringContent);

            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new Exception(await result.Content.ReadAsStringAsync());
            } 

            result.EnsureSuccessStatusCode();
        }

        public async Task Delete<t>(int id, string url)
        {
            HttpClient _httpClient = new HttpClient();

            var uri = "https://localhost:44301/" + url;
            uri = uri.Substring(uri.Length - 1).Equals("/") ? uri : uri + "/";

            _httpClient.BaseAddress = new Uri(uri);
            var result = await _httpClient.DeleteAsync(id.ToString());

            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new Exception(await result.Content.ReadAsStringAsync());
            }

            result.EnsureSuccessStatusCode();
        }
    }
}
