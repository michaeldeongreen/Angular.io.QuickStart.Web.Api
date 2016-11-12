using Angular.io.QuickStart.Web.Api.Models;
using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
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
        private IUoW _uow;

        public HeroesController(IUoW uow)
        {
            _uow = uow;
        }
        // GET: api/Heroes
        public IEnumerable<Hero> Get()
        {
            return _uow.HeroRepository.GetAll();
        }

        // GET: api/Heroes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Heroes
        public void Post([FromBody]string value)
        {
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
