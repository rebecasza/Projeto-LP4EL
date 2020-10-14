using LP4EL.Model.Entities;
using LP4EL.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP4EL.Data.Repositories
{
    class VagasRepository : GenericRepository<Vagas>, IVagasRepository

       
    {
        public VagasRepository(ApplicationContext context)
         : base(context)
        {

        }

    }
}
