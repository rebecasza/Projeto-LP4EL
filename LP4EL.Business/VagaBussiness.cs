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
            throw new System.NotImplementedException();
        }

        public VagasDto Salvar(VagasDto vagasDto)
        {
            var vaga = new Vagas();

            if (vagasDto.IdVaga > 0)
            {
                vaga = this._unitOfWork.VagasRepository.GetById(vagasDto.IdVaga);
                vaga.Nome = vagasDto.Nome;
                vaga.descricao = vagasDto.descricao;
                vaga.NomeCandidato = vagasDto.NomeCandidato;

                this._unitOfWork.VagasRepository.Update(vaga);

                return new VagasDto
                {
                    IdVaga = vaga.IdVaga,
                    Nome = vaga.Nome,
                    NomeCandidato = vaga.NomeCandidato,
                    descricao = vaga.descricao
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
                Nome = vaga.Nome,
                descricao = vaga.descricao,
                NomeCandidato = vaga.NomeCandidato
            };
        }
    }
}  


