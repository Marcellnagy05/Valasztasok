using Microsoft.EntityFrameworkCore;

namespace Valasztasok.Model
{
    public class ValasztasokDbContext : DbContext
    {
        public ValasztasokDbContext(DbContextOptions<ValasztasokDbContext> options) : base(options)
        {

        }

        public DbSet<Jelolt> Jeloltek { get; set; }
        public DbSet<Part> Partok { get; set; }
    }
}
