using Angular.io.QuickStart.Web.Api.Models.DTO;
using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Services
{
    public class HeroValidationService
    {
        private IUoW _uow;
        private HeroDTO _hero;

        public HeroValidationService(IUoW uow)
        {
            _uow = uow;
        }
        public void AddValidation(HeroDTO hero)
        {
            _hero = hero;
            HeroNotNull();
            HeroNameNotNullOrEmpty();
            HeroNameUnique();
        }

        public void SearchValidation(HeroDTO hero)
        {
            _hero = hero;
            HeroNameNotNullOrEmpty();
        }

        private void HeroNotNull()
        {
            if (_hero == null)
                throw new ServiceValidationException("Hero cannot be null.");
        }

        private void HeroNameNotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(_hero.Name))
                throw new ServiceValidationException("Hero name is required");
        }

        private void HeroNameUnique()
        {
            if (_uow.HeroRepository.Get((x) => x.Name == _hero.Name).Count() > 0)
                throw new ServiceValidationException(string.Format("The name {0} already exists.",_hero.Name));
        }
    }
}
