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

        /// <summary>
        /// Endpoint is used to get all heroes in the application
        /// </summary>
        /// <returns>List of Heroes</returns>
        // GET: api/Heroes
        public IQueryable<Hero> Get()
        {
            return _heroService.GetAll();
        }

        /// <summary>
        /// Endpoint is used to get a hero by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Hero that matches the id parameter</returns>
        // GET: api/Heroes/5
        public Hero Get(int id)
        {
            return _heroService.Get(id);
        }

        /// <summary>
        /// Endpoint used to create a new hero
        /// </summary>
        /// <param name="hero"></param>
        // POST: api/Heroes
        public void Post([FromBody]HeroDTO hero)
        {
            _heroService.Add(hero);
        }


        /// <summary>
        /// Endpoint used to update the name of a hero
        /// </summary>
        /// <param name="hero"></param>
        // PUT: api/Heroes/5
        public void Put([FromBody]HeroDTO hero)
        {
            _heroService.Update(hero);
        }


        /// <summary>
        /// Endpoint used to delete a hero by id
        /// </summary>
        /// <param name="id"></param>
        // DELETE: api/Heroes/5
        public void Delete(int id)
        {
            _heroService.Delete(id);
        }
    }
}
