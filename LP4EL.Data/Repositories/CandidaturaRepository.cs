using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LP4EL.Model.Entities;
using LP4EL.Model.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LP4EL.Data.Repositories
{
    class CandidaturaRepository : GenericRepository<Candidatura>, ICandidaturaRepository

    {
        public CandidaturaRepository(ApplicationContext context)
       : base(context)
        {

        }
    }
}