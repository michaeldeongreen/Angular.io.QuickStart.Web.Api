﻿using Angular.io.QuickStart.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.io.QuickStart.Web.Api.Repository.Interfaces
{
    public interface IUoW
    {
        Repository<Hero> HeroRepository { get; }

        int Save();
    }
}
