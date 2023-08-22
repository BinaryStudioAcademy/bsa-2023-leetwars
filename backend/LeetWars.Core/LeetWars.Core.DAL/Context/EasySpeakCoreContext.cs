using LeetWars.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeetWars.Core.DAL.Context
{
    public class LeetWarsCoreContext : DbContext
    {
        public DbSet<Sample> Samples => Set<Sample>();

        public LeetWarsCoreContext(DbContextOptions<LeetWarsCoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();
            modelBuilder.Seed();
        }
    }
}
