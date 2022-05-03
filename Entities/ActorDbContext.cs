using Microsoft.EntityFrameworkCore;

namespace DemoConsole.Entities
{
    internal class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestActorDb;"
            + "Trusted_Connection=true;");  // should go into a connection string in configuration not hardcoded
        }
    }
}
