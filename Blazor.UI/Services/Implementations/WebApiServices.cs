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
            var uri = "https://localhost:44301/" + url;
            var stringContent = new StringContent(JsonSerializer.Serialize(entity), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync(uri, stringContent);

            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                throw new Exception(await result.Content.ReadAsStringAsync());
            } 

            result.EnsureSuccessStatusCode();
        }
    }
}
