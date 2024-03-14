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
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public override void Map(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(150)")
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(e => e.Numero)
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.CEP)
                .HasColumnType("varchar(8)")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(e => e.Cidade)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Estado)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasOne(x => x.Evento)
                .WithOne(o => o.Endereco)
                .HasForeignKey<Endereco>(x => x.EventoId); // aqui o endereço é relacionado com evento
                                                           // por conta do endereço ser o filho do evento

            builder
                .Ignore(x => x.ValidationResult);

            builder
                .Ignore(x => x.CascadeMode);

            builder
                .ToTable("Enderecos");
        }
    }
}
