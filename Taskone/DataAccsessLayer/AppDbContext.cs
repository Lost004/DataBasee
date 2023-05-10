using Microsoft.EntityFrameworkCore;

namespace Taskone.DataAccsessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
    }
}
