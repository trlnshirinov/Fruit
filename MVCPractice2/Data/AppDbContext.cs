using Microsoft.EntityFrameworkCore;

namespace MVCPractice2.Data
    
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
      
        }

    }
}
