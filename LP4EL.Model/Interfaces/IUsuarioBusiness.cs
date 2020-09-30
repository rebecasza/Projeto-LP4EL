using System;
using System.Collections.Generic;
using LP4EL.Model.Dtos;
using LP4EL.Model.Entities;

namespace LP4EL.Model.Interfaces
{
    public interface IUsuarioBusiness
    {
        UsuarioDto Autenticar(LoginDto loginDto);
        IEnumerable<UsuarioDto> Filtrar();
        UsuarioDto Selecionar(int id);
        ResultadoDto Excluir(int id);
        ResultadoDto Salvar(UsuarioDto usuario);
    }
}
