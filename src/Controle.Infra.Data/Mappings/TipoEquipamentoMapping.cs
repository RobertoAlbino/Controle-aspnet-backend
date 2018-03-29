using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    class TipoEquipamentoMapping : EntityTypeConfiguration<TipoEquipamento>
    {
        public override void Map(EntityTypeBuilder<TipoEquipamento> modelBuilder)
        {
            modelBuilder
              .ToTable("TipoEquipamento")
              .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder
              .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
