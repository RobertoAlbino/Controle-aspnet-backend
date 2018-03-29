using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    public class EquipamentoMapping : EntityTypeConfiguration<Equipamento>
    {
        public override void Map(EntityTypeBuilder<Equipamento> modelBuilder)
        {
            modelBuilder
              .ToTable("Equipamentos")
              .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder
               .Property(x => x.Marca)
               .HasColumnType("varchar(150)")
               .IsRequired();

            modelBuilder
                .HasOne(x => x.TipoEquipamento)
                .WithMany(x => x.Equipamento)
                .HasForeignKey(x => x.IdTipoEquipamento)
                .IsRequired();

            modelBuilder
              .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
