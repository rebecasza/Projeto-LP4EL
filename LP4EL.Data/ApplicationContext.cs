using System;
using LP4EL.Data.Mapping;
using LP4EL.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;



namespace LP4EL.Data
{
	public class ApplicationContext : DbContext
	{
		private readonly ILogger<ApplicationContext> _logger;


		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Vagas> Vagas { get; set; }

		public ApplicationContext(DbContextOptions<ApplicationContext> options, ILogger<ApplicationContext> logger)
			: base(options)
		{
			_logger = logger;
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_logger.Log(LogLevel.Information, "OnModelCreating...");
			modelBuilder.ApplyConfiguration(new UsuarioConfig());
			modelBuilder.ApplyConfiguration(new VagaConfig());
		}
	}
}
