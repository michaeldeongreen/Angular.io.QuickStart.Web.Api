using Angular.io.QuickStart.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Repository
{
    public class TourOfHeroesContext : DbContext
    {
        public TourOfHeroesContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<Hero> Heroes { get; set; }
    }
}
