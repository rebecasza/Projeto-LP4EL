using System;
using System.Collections.Generic;
using System.Text;
using LP4EL.Data.Repositories;
using LP4EL.Model.Interfaces;

namespace LP4EL.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		public ApplicationContext Context { get; internal set; }

		private IUsuarioRepository usuarioRepository;

		private IVagasRepository vagasRepository;

		private ICandidaturaRepository candidaturaRepository;

		public UnitOfWork(ApplicationContext context)
		{
			this.Context = context;
		}

		public IUsuarioRepository UsuarioRepository
		{
			get
			{
				if (this.usuarioRepository == null)
					this.usuarioRepository = new UsuarioRepository(this.Context);
				return this.usuarioRepository;
			}
		}
			public IVagasRepository VagasRepository
		{
			get
			{
				if (this.vagasRepository == null)
					this.vagasRepository = new VagasRepository(this.Context);
				return this.vagasRepository;
			}
		}


		public ICandidaturaRepository CandidaturaRepository
		{
			get
			{
				if (this.candidaturaRepository == null)
					this.candidaturaRepository = new CandidaturaRepository(this.Context);
				return this.candidaturaRepository;
			}
		}


		public bool SaveChanges()
		{
			return this.Context.SaveChanges() > 0;
		}
	}
}
