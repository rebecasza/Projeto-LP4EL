using LP4EL.Model.Dtos;
using LP4EL.Model.Entities;
using LP4EL.Model.Interfaces;
using LP4EL.Utils;
using System.Collections.Generic;
using System.Linq;

namespace LP4EL.Business
{
    public class CandidaturaBusiness : ICandidaturaBusiness

    {

        private readonly IUnitOfWork _unitOfWork;

        public CandidaturaBusiness(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public ResultadoDto Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CandidaturaDto> Filtrar()
        {
            var query = this._unitOfWork
                    .CandidaturaRepository
                    .Get(null, o => o.OrderBy(u => u.IdCandidatura))
                    .Select(s => new CandidaturaDto
                    {
                        IdCandidatura = s.IdCandidatura,
                        IdUsuario = s.IdUsuario,
                        IdVaga = s.IdVaga,
                    });
            return query.ToList();
        }

        public CandidaturaDto Salvar(CandidaturaDto candidaturaDto)
        {
            var candidatura = new Candidatura();

            if (candidaturaDto.IdCandidatura > 0)
            {
                candidatura = this._unitOfWork.CandidaturaRepository.GetById(candidatura.IdCandidatura);
                candidatura.IdUsuario = candidaturaDto.IdUsuario;
                candidatura.IdVaga = candidaturaDto.IdCandidatura;

                this._unitOfWork.CandidaturaRepository.Update(candidatura);

                return new CandidaturaDto
                {
                    IdCandidatura = candidatura.IdCandidatura,
                    IdUsuario = candidatura.IdUsuario,
                    IdVaga = candidatura.IdVaga,

                };

            }

            else
            {
                return null;

            }
        }

        public CandidaturaDto Selecionar(int id)
        {
            var candidatura = this._unitOfWork
                   .CandidaturaRepository
                   .GetById(id);

            return new CandidaturaDto
            {
                IdCandidatura = candidatura.IdCandidatura,
                IdUsuario = candidatura.IdUsuario,
                IdVaga = candidatura.IdVaga,
            };
        }

        ResultadoDto ICandidaturaBusiness.Salvar(CandidaturaDto candidaturaDto)
        {
            var candidatura = new Candidatura();

            if (candidaturaDto.IdCandidatura > 0)
            {
                candidatura = this._unitOfWork.CandidaturaRepository.GetById(candidaturaDto.IdCandidatura);
                candidatura.IdUsuario = candidatura.IdUsuario;
                candidatura.IdVaga = candidatura.IdVaga;

                this._unitOfWork.CandidaturaRepository.Update(candidatura);
            }
            else

            {

                candidatura = new Candidatura();
                candidatura.IdUsuario = candidatura.IdUsuario;
                candidatura.IdVaga = candidatura.IdVaga;


                this._unitOfWork.CandidaturaRepository.Add(candidatura);
            }

            var sucesso = this._unitOfWork.SaveChanges();
            var resultado = new ResultadoDto
            {
                Sucesso = sucesso,
                Id = candidatura.IdCandidatura
            };

            return resultado;
        }
    }
}


