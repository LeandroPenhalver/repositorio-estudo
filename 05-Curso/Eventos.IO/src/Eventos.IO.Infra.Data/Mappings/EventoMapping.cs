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
    public class EventoMapping : EntityTypeConfiguration<Evento>
    {
        public override void Map(EntityTypeBuilder<Evento> builder)
        {

            builder
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder
                .Property(x => x.DescricaoCurta)
                .HasColumnType("varchar(150)");

            builder
                .Property(x => x.DescricaoLonga)
                .HasColumnType("varchar(max)");

            builder
                .Property(x => x.NomeEmpresa)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder
                .Ignore(x => x.ValidationResult);

            builder
                .Ignore(x => x.Tags);

            builder
                .Ignore(x => x.CascadeMode);

            builder
                .ToTable("Eventos");

            // Relacionamento de evento para organizador
            builder
                .HasOne(x => x.Organizador) // evento tem um organizador
                .WithMany(o => o.Eventos) // porem um organizador tem muitos evetos.
                .HasForeignKey(x => x.OrganizadorId); // FK na evento

            builder
                .HasOne(x => x.Categoria)
                .WithMany(o => o.Eventos)
                .HasForeignKey(x => x.CategoriaId)
                .IsRequired(false); // só é possível setar essa propriedade como não requirido pq a
                                    // pripriedade categoria id é null para o evento
                                    // "public Guid? CategoriaId { get; private set; }"
        }
    }
}
