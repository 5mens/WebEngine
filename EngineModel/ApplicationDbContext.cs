using EngineModels.Models.Menus;
using EngineModels.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace EngineModels
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=engine;Trusted_Connection=True;");
        }
    }
}
