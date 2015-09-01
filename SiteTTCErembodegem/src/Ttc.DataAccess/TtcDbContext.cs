using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ttc.Model;

namespace Ttc.DataAccess
{
    public class TtcDbContext : DbContext
    {
        public TtcDbContext() : base("ttc")
        {
            Database.SetInitializer<TtcDbContext>(new TtcDbInitializer());
        }

        public DbSet<Ttc.Model.Speler> Spelers { get; set; }
        public DbSet<Ttc.Model.Match> Matches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
