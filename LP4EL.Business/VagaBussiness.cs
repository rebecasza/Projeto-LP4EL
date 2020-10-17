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
                        Descricao = s.Descricao,
                        Localizacao = s.Localizacao
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
                vaga.Localizacao = vagasDto.Localizacao;

                this._unitOfWork.VagasRepository.Update(vaga);

                return new VagasDto
                {
                    IdVaga = vaga.IdVaga,
                    Titulo = vaga.Titulo,
                    Descricao = vaga.Descricao,
                    Localizacao = vaga.Localizacao
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
                Localizacao = vaga.Localizacao
            };
        }

        ResultadoDto IVagasBusiness.Salvar(VagasDto vagasDto)
        {
            var vagas = new Vagas();

            if (vagasDto.IdVaga > 0)
            {
                vagas = this._unitOfWork.VagasRepository.GetById(vagasDto.IdVaga);
                vagas.Titulo = vagas.Titulo;
                vagas.Descricao = vagas.Descricao;
                vagas.Localizacao = vagas.Localizacao;

                this._unitOfWork.VagasRepository.Update(vagas);
            }
            else

            {

                vagas = new Vagas();
                vagas.Titulo = vagasDto.Titulo;
                vagas.Descricao = vagasDto.Descricao;
                vagas.Localizacao = vagasDto.Localizacao;

                this._unitOfWork.VagasRepository.Add(vagas);
            }

            var sucesso = this._unitOfWork.SaveChanges();
            var resultado = new ResultadoDto
            {
                Sucesso = sucesso,
                Id = vagas.IdVaga
            };

            return resultado;
        }
    }
}  


