using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    public class PaisMapping : EntityTypeConfiguration<Pais>
    {
        public override void Map(EntityTypeBuilder<Pais> modelBuilder)
        {
            modelBuilder
               .ToTable("Paises")
               .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder
              .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
