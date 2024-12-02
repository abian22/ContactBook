using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }

        public DbSet<User> Users {  get; set; }
    }
}
