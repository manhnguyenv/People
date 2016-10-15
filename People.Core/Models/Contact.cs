using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace People.Core.Models
{
    public class Contact
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("photoUrl")]
        public string PhotoUrl { get; set; }

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
