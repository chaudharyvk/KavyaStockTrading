using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StocktradingDBContext : DbContext
    {
        public StocktradingDBContext() : base("StocktradingConnectionstring")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StocktradingDBContext, DataLayer.Migrations.Configuration>("StocktradingConnectionstring"));
        }

        public DbSet<RegisterUser> RegisterUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
               .Properties()
               .Where(p => p.Name == p.DeclaringType.Name + "_ID")
               .Configure(p => p.IsKey());


            base.OnModelCreating(modelBuilder);
        }
    }
}
