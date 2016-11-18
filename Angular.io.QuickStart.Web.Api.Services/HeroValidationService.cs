﻿using Angular.io.QuickStart.Web.Api.Models.DTO;
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
        public void Validate(HeroDTO hero)
        {
            _hero = hero;
            HeroNotNull();
            HeroNameNotNullOrEmpty();
        }

        private void HeroNotNull()
        {
            if (_hero == null)
                throw new Exception("Hero cannot be null.");
        }

        private void HeroNameNotNullOrEmpty()
        {
            if (string.IsNullOrEmpty(_hero.Name))
                throw new Exception("Hero name is required");
        }

        private void HeroNameUnique()
        {
        }
    }
}
