using System;
using LP4EL.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LP4EL.Data.Mapping
{
	public class CandidaturaConfig : IEntityTypeConfiguration<Candidatura>
	{
		public void Configure(EntityTypeBuilder<Candidatura> builder)
		{
			builder.ToTable("Candidatura");
			builder.HasKey(t => t.IdCandidatura);
			builder.Property(t => t.IdCandidatura);
			builder.Property(t => t.IdUsuario);
			builder.Property(t => t.IdVaga);


		}



	}
}
