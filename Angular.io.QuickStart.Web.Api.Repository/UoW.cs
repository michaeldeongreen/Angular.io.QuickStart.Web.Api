using Angular.io.QuickStart.Web.Api.Models;
using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Repository
{
    public class UoW : IUoW
    {
        private TourOfHeroesContext _dbContext;

        public Repository<Hero> HeroRepository { get; private set; }

        public UoW(TourOfHeroesContext dbContext)
        {
            _dbContext = dbContext;
            HeroRepository = new Repository<Hero>(_dbContext);
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
