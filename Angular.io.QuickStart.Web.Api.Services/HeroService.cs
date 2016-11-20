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
        private HeroValidationService _heroValidationService;

        public HeroService(IUoW uow, HeroValidationService heroValidationService)
        {
            _uow = uow;
            _heroValidationService = heroValidationService;
        }

        public IQueryable<Hero> GetAll()
        {
            return _uow.HeroRepository.GetAll();
        }

        public Hero Get(int id)
        {
            return _uow.HeroRepository.Get(id);
        }

        public IEnumerable<Hero> Get(string name)
        {
            _heroValidationService.SearchValidation(new HeroDTO() { Name = name });
            return _uow.HeroRepository.Get((x) => x.Name.ToLower().Contains(name.ToLower()));
        }

        public Hero Add(HeroDTO hero)
        {
            _heroValidationService.AddValidation(hero);
           var newHero  = _uow.HeroRepository.Add(new Hero() { Name = hero.Name });
            Save();

            return newHero;
        }

        public void Delete(int id)
        {

            _heroValidationService.DeleteValidation(new HeroDTO() { Id = id });
            _uow.HeroRepository.Delete(id);
            Save();
        }

        public void Update(HeroDTO hero)
        {
            _heroValidationService.UpdateValidation(hero);
            Hero heroToUpdate = _uow.HeroRepository.Get(hero.Id);

            heroToUpdate.Name = hero.Name;
            _uow.HeroRepository.Update(heroToUpdate);
            Save();
        }

        private void Save()
        {
            _uow.Save();
        }
    }
}
