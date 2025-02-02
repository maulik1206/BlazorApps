using BlazorApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
