using Angular.io.QuickStart.Web.Api.Models;
using Angular.io.QuickStart.Web.Api.Models.DTO;
using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Services
{
    public class HeroService
    {
        private IUoW _uow;

        public HeroService(IUoW uow)
        {
            _uow = uow;
        }

        public IQueryable<Hero> GetAll()
        {
            return _uow.HeroRepository.GetAll();
        }

        public Hero GetById(int id)
        {
            return _uow.HeroRepository.Get(id);
        }

        public void Add(HeroDTO heroDto)
        {
            _uow.HeroRepository.Add(new Hero() { Name = heroDto.Name });
            _uow.Save();
        }
    }
}
