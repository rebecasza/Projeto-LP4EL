﻿using LP4EL.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LP4EL.Model.Interfaces
{
    public interface IVagasBusiness
    {
        VagasDto Salvar(VagasDto vagas);
        IEnumerable<VagasDto> Filtrar();
        VagasDto Selecionar(int id);
        ResultadoDto Excluir(int id);
      
    }
}
