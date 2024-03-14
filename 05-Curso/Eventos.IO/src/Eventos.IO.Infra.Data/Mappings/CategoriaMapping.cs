using Eventos.IO.Infra.Data.Extensions;
using LOP.Eventos.IO.Domain.Eventos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.IO.Infra.Data.Mappings
{
    public class CategoriaMapping : EntityTypeConfiguration<Categoria>
    {
        public override void Map(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(e => e.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder
                .Ignore(x => x.ValidationResult);

            builder
                .Ignore(x => x.CascadeMode);

            builder
                .ToTable("Categorias");
        }
    }
}
