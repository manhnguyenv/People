using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using People.Core.Models;

namespace People.Core.Services
{
    public class PeopleService : IPeopleService
    {
        public const string Host = "http://people-sharp.azurewebsites.net";
        public async Task<List<Contact>> GetContacts()
        {
            using (var httpClient = new HttpClient(new HttpClientHandler()))
            {
                var response = await httpClient.GetStringAsync(Host + "/api/contacts");
                return JsonConvert.DeserializeObject<List<Contact>>(response);
            }
        }
    }
}
