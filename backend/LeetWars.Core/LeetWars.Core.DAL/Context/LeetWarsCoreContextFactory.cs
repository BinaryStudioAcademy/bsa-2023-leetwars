using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LeetWars.Core.DAL.Context
{
    public class LeetWarsCoreContextFactory : IDesignTimeDbContextFactory<LeetWarsCoreContext>
    {
        public LeetWarsCoreContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LeetWarsCoreContext>();
            //For local migration manipulation set SqlServer Connection string for machine's Sql Server instance
            optionsBuilder.UseSqlServer("Server=(localDB)\\mssqllocaldb;Database=LeetWarsCoreDB;Trusted_Connection=True;");

            return new LeetWarsCoreContext(optionsBuilder.Options);
        }
    }
}
