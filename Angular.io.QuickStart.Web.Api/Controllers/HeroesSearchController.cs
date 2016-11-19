using Angular.io.QuickStart.Web.Api.Models;
using Angular.io.QuickStart.Web.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular.io.QuickStart.Web.Api.Controllers
{
    public class HeroesSearchController : ApiController
    {
        private HeroService _heroService;

        public HeroesSearchController(HeroService heroService)
        {
            _heroService = heroService;
        }

        /// <summary>
        /// Endpoint is used to get all heroes whose name contains the name parameter
        /// </summary>
        /// <param name="name"></param>
        /// <returns>List of heroes whose name contains the name parameter</returns>
        public IEnumerable<Hero> Get(string name)
        {
            return _heroService.Get(name);
        }

    }
}
