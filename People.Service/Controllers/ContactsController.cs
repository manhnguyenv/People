using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using People.Service.Model;

namespace People.Service.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
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
            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return _context.Contacts.Where(x=>x.OwnerId == userId).ToList();
        }
    }
}