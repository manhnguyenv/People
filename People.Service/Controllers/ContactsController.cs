using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using People.Service.Model;

namespace People.Service.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly PeopleDbContext _context;

        public ContactsController(PeopleDbContext context)
        {
            _context = context;
        }

        // GET: api/contacts
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return _context.Contacts.ToList();
        }
    }
}