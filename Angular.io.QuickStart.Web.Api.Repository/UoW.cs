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
        public HeroRepository HeroRepository { get; private set; }


        public UoW()
        {
            HeroRepository = new HeroRepository();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
