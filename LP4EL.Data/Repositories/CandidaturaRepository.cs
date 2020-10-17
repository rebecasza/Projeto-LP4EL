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

        public void Add(Candidatura entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<Candidatura> list)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<Candidatura, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Delete(Candidatura entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Vagas, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Candidatura> Get(Expression<Func<Vagas, bool>> expression = null, Func<IQueryable<Vagas>, IOrderedQueryable<Vagas>> orderby = null, string includes = "", bool noTracking = false)
        {
            throw new NotImplementedException();
        }

        public void Update(Candidatura entity)
        {
            throw new NotImplementedException();
        }

        Candidatura IGenericRepository<Candidatura>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
