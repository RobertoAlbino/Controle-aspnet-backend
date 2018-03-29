using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    public class EstadoMapping : EntityTypeConfiguration<Estado>
    {
        public override void Map(EntityTypeBuilder<Estado> modelBuilder)
        {
            modelBuilder
                .ToTable("Estados")
                .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder
                .HasOne(x => x.Pais)
                .WithMany(x => x.Estado)
                .HasForeignKey(x => x.IdPais)
                .IsRequired();

            modelBuilder
              .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
