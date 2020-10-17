using LP4EL.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP4EL.Model.Interfaces
{
    public interface ICandidaturaBusiness
    {
        IEnumerable<CandidaturaDto> Filtrar();
        CandidaturaDto Selecionar(int id);
        ResultadoDto Excluir(int id);
        ResultadoDto Salvar(CandidaturaDto candidatura);

    }
}
