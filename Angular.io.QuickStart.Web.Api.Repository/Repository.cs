using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        private TourOfHeroesContext _dboContext;
        private DbSet<TEntity> _dbSet;

        public Repository(TourOfHeroesContext dbContext)
        {
            _dboContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }
    
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }
    }
}
