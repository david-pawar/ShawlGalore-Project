using Microsoft.EntityFrameworkCore;
using ShawlGalore.Models;

namespace ShawlGalore.Data
{
    public class ShawlGaloreContext : DbContext
    {
        public ShawlGaloreContext(DbContextOptions<ShawlGaloreContext> options)
            : base(options)
        {
        }

        public DbSet<Shawl> Shawl { get; set; }
    }
}