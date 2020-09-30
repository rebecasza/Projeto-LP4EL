using System;
using System.Collections.Generic;
using System.Text;

namespace LP4EL.Model.Interfaces
{
    public interface IUnitOfWork
    {
        IUsuarioRepository UsuarioRepository { get; }

        bool SaveChanges();
    }
}
