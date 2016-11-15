using System.Collections.Generic;
using System.Threading.Tasks;
using People.Core.Models;

namespace People.Core.Services
{
public interface IPeopleService
{
    Task<List<Contact>> GetContacts();
    Task<bool> LoginAsync(string username, string password);
    Task<bool> RegisterAsync(string username, string email, string password);
}
}