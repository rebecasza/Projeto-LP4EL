using System;
using LP4EL.Model.Entities;
using LP4EL.Model.Interfaces;

namespace LP4EL.Data.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationContext context)
            : base(context)
        {
        }
    }
}
