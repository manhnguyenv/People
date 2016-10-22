using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace People.Service.Model
{
    public class PeopleDbContext : IdentityDbContext<ApplicationUser>
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}