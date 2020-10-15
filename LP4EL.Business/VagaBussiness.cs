using LP4EL.Model.Dtos;
using LP4EL.Model.Entities;
using LP4EL.Model.Interfaces;
using LP4EL.Utils;
using System.Collections.Generic;
using System.Linq;

namespace LP4EL.Business
{
    public class VagasBusiness : IVagasBusiness
    {

        private readonly IUnitOfWork _unitOfWork;

        public VagasBusiness(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public ResultadoDto Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<VagasDto> Filtrar()
        {
            var query = this._unitOfWork
                    .VagasRepository
                    .Get(null, o => o. OrderBy(u => u.Titulo))
                    .Select(s => new VagasDto
                    {
                        IdVaga = s.IdVaga,
                        Titulo = s.Titulo,
                        Descricao = s.Descricao
                    });
                return query.ToList();
        }

        public VagasDto Salvar(VagasDto vagasDto)
        {
            var vaga = new Vagas();

            if (vagasDto.IdVaga > 0)
            {
                vaga = this._unitOfWork.VagasRepository.GetById(vagasDto.IdVaga);
                vaga.Titulo = vagasDto.Titulo;
                vaga.Descricao = vagasDto.Descricao;

                this._unitOfWork.VagasRepository.Update(vaga);

                return new VagasDto
                {
                    IdVaga = vaga.IdVaga,
                    Titulo = vaga.Titulo,
                    Descricao = vaga.Descricao,
                };

            }

            else
            {
                return null;

            }
        }

        public VagasDto Selecionar(int id)
        {
            var vaga = this._unitOfWork
                   .VagasRepository
                   .GetById(id);

            return new VagasDto
            {
                IdVaga = vaga.IdVaga,
                Titulo = vaga.Titulo,
                Descricao = vaga.Descricao,
            };
        }

        ResultadoDto IVagasBusiness.Salvar(VagasDto vagas)
        {
            throw new System.NotImplementedException();
        }
    }
}  


