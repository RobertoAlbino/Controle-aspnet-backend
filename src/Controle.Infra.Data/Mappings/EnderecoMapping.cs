using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public override void Map(EntityTypeBuilder<Endereco> modelBuilder)
        {
            modelBuilder
              .ToTable("Enderecos")
              .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.CEP)
                .HasColumnType("varchar(8)")
                .IsRequired();

            modelBuilder
               .Property(x => x.Rua)
               .HasColumnType("varchar(150)")
               .IsRequired();

            modelBuilder
               .Property(x => x.Bairro)
               .HasColumnType("varchar(150)")
               .IsRequired();

            modelBuilder
                .HasOne(x => x.Cidade)
                .WithMany(x => x.Endereco)
                .HasForeignKey(x => x.IdCidade)
                .IsRequired();

            modelBuilder
              .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
