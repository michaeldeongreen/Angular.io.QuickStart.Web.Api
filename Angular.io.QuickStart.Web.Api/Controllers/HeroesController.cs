using Angular.io.QuickStart.Web.Api.Models;
using Angular.io.QuickStart.Web.Api.Models.DTO;
using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using Angular.io.QuickStart.Web.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular.io.QuickStart.Web.Api.Controllers
{
    public class HeroesController : ApiController
    {
        private HeroService _heroService;

        public HeroesController(HeroService heroService)
        {
            _heroService = heroService;
        }
        // GET: api/Heroes
        public IQueryable<Hero> Get()
        {
            return _heroService.GetAll();
        }

        // GET: api/Heroes/5
        public Hero Get(int id)
        {
            return _heroService.GetById(id);
        }

        // POST: api/Heroes
        public void Post([FromBody]HeroDTO hero)
        {
            _heroService.Add(hero);
        }

        // PUT: api/Heroes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Heroes/5
        public void Delete(int id)
        {
        }
    }
}
