using Angular.io.QuickStart.Web.Api.Models;
using Angular.io.QuickStart.Web.Api.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular.io.QuickStart.Web.Api
{
    public static class DatabaseSeedConfig
    {
        public static void CreateSeedData(IUoW uow)
        {
            CreateHeroData(uow);

            uow.Save();
        }

        private static void CreateHeroData(IUoW uow)
        {
            if (uow.HeroRepository.GetAll().Count() == 0)
            {
                uow.HeroRepository.Add(new Hero() { Id = 1, Name = "Mr. Nice" });
                uow.HeroRepository.Add(new Hero() { Id = 2, Name = "Narco" });
                uow.HeroRepository.Add(new Hero() { Id = 3, Name = "Bombasto" });
                uow.HeroRepository.Add(new Hero() { Id = 4, Name = "Celeritas" });
                uow.HeroRepository.Add(new Hero() { Id = 5, Name = "Magneta" });
                uow.HeroRepository.Add(new Hero() { Id = 6, Name = "RubberMan" });
                uow.HeroRepository.Add(new Hero() { Id = 7, Name = "Dynama" });
                uow.HeroRepository.Add(new Hero() { Id = 8, Name = "Dr. IQ" });
                uow.HeroRepository.Add(new Hero() { Id = 9, Name = "Magma" });
                uow.HeroRepository.Add(new Hero() { Id = 10, Name = "Tornado" });
            }
        }
    }
}