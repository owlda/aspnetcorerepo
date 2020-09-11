using apsnetproject.Models;
using Microsoft.EntityFrameworkCore;

namespace apsnetproject.Persistence
{
    public class ModelsDBContext: DbContext
    {

        public ModelsDBContext(DbContextOptions<ModelsDBContext> options): base(options)
        {
            //ctor for the DBContext
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Office> Offices { get; set; }       
        public DbSet<Contact> Contacts { get; set; }
       
        
    }
}