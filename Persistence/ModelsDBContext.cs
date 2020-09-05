using Microsoft.EntityFrameworkCore;

namespace apsnetproject.Persistence
{
    public class ModelsDBContext: DbContext
    {

        public ModelsDBContext(DbContextOptions<ModelsDBContext> options): base(options)
        {
            
        }
        
    }
}