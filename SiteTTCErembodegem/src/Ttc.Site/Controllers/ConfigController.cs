using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Ttc.Dtos;

namespace Ttc.Site.Controllers
{
    [Route("api/[controller]")]
    public class ConfigController : ApiController
    {
        public TtcConfiguration Get()
        {
            return new TtcConfiguration
            {
                StandardCompetitionStart = new TimeSpan(20, 0, 0)
            };
        }
    }
}
