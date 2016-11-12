using Angular.io.QuickStart.Web.Api.Models;
using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Repository
{
    public class HeroRepository : IRepository<Hero>
    {
        public IEnumerable<Hero> GetAll()
        {
            return new List<Hero>() { new Hero() { Id = 1, Name = "Martin Luther King Jr." }, new Hero() { Id = 2, Name = "Mahatma Gandhi",  }, new Hero() { Id = 3, Name = "Rosa Parks" },
            new Hero() { Id = 4, Name = "Mother Teresa" }, new Hero() { Id = 5, Name = "Lyndon Baines Johnson" }};
        }
    }
}
