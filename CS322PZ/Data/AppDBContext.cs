using Microsoft.EntityFrameworkCore;

namespace CS322PZ.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
            
        }
    }
}
