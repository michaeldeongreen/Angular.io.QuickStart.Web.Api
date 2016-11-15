using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System.Data.Entity;

namespace Angular.io.QuickStart.Web.Api.Repository
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            Scan( scan => {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
            For<TourOfHeroesContext>().Use<TourOfHeroesContext>().Ctor<string>().Is("TourOfHeroesContext");
        }
    }
}
