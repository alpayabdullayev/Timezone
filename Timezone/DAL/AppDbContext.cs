using Microsoft.EntityFrameworkCore;
using Timezone.Models;

namespace Timezone.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }

}
