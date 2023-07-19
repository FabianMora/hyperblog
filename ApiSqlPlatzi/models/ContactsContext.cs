using Microsoft.EntityFrameworkCore;

namespace ApiSqlPlatzi.models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Contacts> ContactSet{get; set;}
    }
}