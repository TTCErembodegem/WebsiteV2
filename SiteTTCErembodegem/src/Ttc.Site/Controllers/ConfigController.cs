using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Ttc.Dtos;
using Ttc.Services;

namespace Ttc.Site.Controllers
{
    [Route("api/[controller]")]
    public class ConfigController : ApiController
    {
        private readonly ConfigService _configService;

        public ConfigController()
        {
            _configService = new ConfigService();
        }

        public TtcConfiguration Get()
        {
            //using (var db = new TtcDbContext())
            //{

            //}
            return _configService.GetConfiguration();
        }
    }
}



//namespace Ttc.DataAccess
//{
//    public class TtcDbContext : DbContext
//    {
//        public TtcDbContext() : base("ttc")
//        {
//            Database.SetInitializer<TtcDbContext>(new TtcDbInitializer());
//        }

//        //public DbSet<Speler> Spelers { get; set; }
//        //public DbSet<Match> Matches { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//        }
//    }

//    /// <summary>
//    /// Initial Database seeding
//    /// </summary>
//    public class TtcDbInitializer : CreateDatabaseIfNotExists<TtcDbContext>
//    {
//        //protected override void Seed(TtcDbContext context)
//        //{
//        //    context.Spelers.Add(new Speler());
//        //    base.Seed(context);
//        //}
//    }
//}

