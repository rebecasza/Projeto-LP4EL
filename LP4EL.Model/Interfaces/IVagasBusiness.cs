using System;
using System.Collections.Generic;
using LP4EL.Model.Dtos;
using LP4EL.Model.Entities;

namespace LP4EL.Model.Interfaces
{
    public interface IVagasBusiness
    {
        IEnumerable<VagasDto> Filtrar();
        VagasDto Selecionar(int id);
        ResultadoDto Excluir(int id);
        ResultadoDto Salvar(VagasDto vagas);

    }
}
