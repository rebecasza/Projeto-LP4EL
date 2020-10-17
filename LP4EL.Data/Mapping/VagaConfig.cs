using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LP4EL.Model.Dtos;
using LP4EL.Model.Entities;

namespace LP4EL.Data.Mapping
{
    class VagaConfig : IEntityTypeConfiguration<Vagas>
	{
		public void Configure(EntityTypeBuilder<Vagas> builder)
		{
			builder.ToTable("Vagas");
			builder.HasKey(t => t.IdVaga);
			builder.Property(t => t.IdVaga);
			builder.Property(t => t.Titulo);
			builder.Property(t => t.Descricao);
			builder.Property(t => t.Localizacao);

		}



	}
}
