using games_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace games_webapi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<Developer>? Developers { get; set; }
        public DbSet<Game>? Games { get; set; }
    }
}
