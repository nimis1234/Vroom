using Microsoft.EntityFrameworkCore;
using Vroom.Model;

namespace Vroom.ApDbContext
{
    // method to intialise DBcontext
    public class AppDbContext:DbContext
        
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Vroom.Model.Model> Models { get; set; }
        public DbSet<Features> Features { get; set; }
    }
}
