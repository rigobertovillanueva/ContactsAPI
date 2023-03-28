using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactAPIDbContext : DbContext
    {
        public ContactAPIDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
