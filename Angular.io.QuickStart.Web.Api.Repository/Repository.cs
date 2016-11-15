using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        private TourOfHeroesContext _dboContext;

        public Repository(TourOfHeroesContext dbContext)
        {
            _dboContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
          return _dboContext.Set<TEntity>();
        }
    }
}
