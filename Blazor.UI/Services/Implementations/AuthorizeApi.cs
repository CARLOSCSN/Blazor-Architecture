using Client.Services.Contracts;
using Common.ViewModel;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Client.Services.Implementations
{
    public class AuthorizeApi : IAuthorizeApi
    {
        private readonly HttpClient _httpClient;

        public AuthorizeApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Login(LoginParametersViewModel loginParameters)
        {
            var stringContent = new StringContent(JsonSerializer.Serialize(loginParameters), Encoding.UTF8, "application/json");

            var requestMessage = new HttpRequestMessage()
            {
                Method = new HttpMethod("POST"),
                RequestUri = new Uri("https://localhost:44301/api/Authorize/Login"),
                Content = stringContent
            };

            requestMessage.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);

            var result = await _httpClient.SendAsync(requestMessage);

            //var result = await _httpClient.PostAsync("https://localhost:44301/api/Authorize/Login", stringContent);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task Logout()
        {
            var requestMessage = new HttpRequestMessage()
            {
                Method = new HttpMethod("POST"),
                RequestUri = new Uri("https://localhost:44301/api/Authorize/Logout"),
                Content = null
            };

            requestMessage.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);

            var result = await _httpClient.SendAsync(requestMessage);

            result.EnsureSuccessStatusCode();
        }

        public async Task Register(RegisterParametersViewModel registerParameters)
        {
            var stringContent = new StringContent(JsonSerializer.Serialize(registerParameters), Encoding.UTF8, "application/json");

            var requestMessage = new HttpRequestMessage()
            {
                Method = new HttpMethod("POST"),
                RequestUri = new Uri("https://localhost:44301/api/Authorize/Register"),
                Content = stringContent
            };

            requestMessage.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);

            var result = await _httpClient.SendAsync(requestMessage);

            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task<UserInfoViewModel> GetUserInfo()
        {
            var json = String.Empty;

            var requestMessage = new HttpRequestMessage()
            {
                Method = new HttpMethod("GET"),
                RequestUri = new Uri("https://localhost:44301/api/Authorize/UserInfo")
            };

            requestMessage.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);

            var response = await _httpClient.SendAsync(requestMessage);

            using (HttpContent content = response.Content)
            {
                json = content.ReadAsStringAsync().Result;
            }

            var result = JsonSerializer.Deserialize<UserInfoViewModel>(
                json, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );

            return result;
        }
    }
}
