using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using People.Core.Models;

namespace People.Core.Services
{
    public class PeopleService : IPeopleService
    {
        public const string Host = "http://people-sharp.azurewebsites.net";
        private string Token { get; set; }


        public async Task<List<Contact>> GetContacts()
        {
            using (var httpClient = new HttpClient(new HttpClientHandler()))
            {                
                var request = new HttpRequestMessage(HttpMethod.Get, Host + "/api/contacts");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var response = await httpClient.SendAsync(request);
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Contact>>(content);
            }
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            using (var httpClient = new HttpClient(new HttpClientHandler()))
            {
                var request = new HttpRequestMessage(HttpMethod.Post, Host + "/api/account/login");
                var json = JsonConvert.SerializeObject(new { Username = username, Password = password });
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }

                var content = await response.Content.ReadAsStringAsync();

                Token = JObject.Parse(content).Value<string>("access_token");

                return true;
            }
        }

        public async Task<bool> RegisterAsync(string username, string email, string password)
        {
            using (var httpClient = new HttpClient(new HttpClientHandler()))
            {
                var request = new HttpRequestMessage(HttpMethod.Post, Host + "/api/account/register");
                var json = JsonConvert.SerializeObject(new { Email = email, Username = username, Password = password });
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.SendAsync(request);

                return response.IsSuccessStatusCode;
            }
        }
    }
}
