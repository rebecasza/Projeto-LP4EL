using System;
using LP4EL.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LP4EL.Data.Mapping
{
	public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
	{
		public void Configure(EntityTypeBuilder<Usuario> builder)
		{
			builder.ToTable("Usuario");
			builder.HasKey(t => t.IdUsuario);
			builder.Property(t => t.IdUsuario);
			builder.Property(t => t.Nome);
			builder.Property(t => t.Email);
			builder.Property(t => t.Login);
			builder.Property(t => t.Hash);
			builder.Property(t => t.Salt);

		}



	}
}
