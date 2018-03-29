using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    public class CidadeMapping : EntityTypeConfiguration<Cidade>
    {
        public override void Map(EntityTypeBuilder<Cidade> modelBuilder)
        {
            modelBuilder
                .ToTable("Cidades")
                .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder
                .HasOne(x => x.Estado)
                .WithMany(x => x.Cidade)
                .HasForeignKey(x => x.IdEstado)
                .IsRequired();

            modelBuilder
               .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
