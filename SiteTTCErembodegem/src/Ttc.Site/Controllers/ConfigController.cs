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
            return _configService.GetConfiguration();
        }
    }
}