using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ttc.Dtos;
//using Ttc.DataAccess;

namespace Ttc.Services
{
    public class ConfigService
    {
        public TtcConfiguration GetConfiguration()
        {
            using (var db = new Ttc.DataAccess.TtcDbContext())
            {
                var plts = db.Spelers.ToArray();

                return new TtcConfiguration
                {
                    StandardCompetitionStart = new TimeSpan(20, 30, 0)
                };
            }
        }
    }
}
