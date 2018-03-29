using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    public class OrdemServicoMapping : EntityTypeConfiguration<OrdemServico>
    {
        public override void Map(EntityTypeBuilder<OrdemServico> modelBuilder)
        {
            modelBuilder
               .ToTable("OrdemServico")
               .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Problema)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder
                .Property(x => x.Atendida)
                .IsRequired();

            modelBuilder
                .HasOne(x => x.Equipamento)
                .WithMany(x => x.OrdemServico)
                .HasForeignKey(x => x.IdEquipamento)
                .IsRequired();

            modelBuilder
               .HasOne(x => x.Cliente)
               .WithMany(x => x.OrdemServico)
               .HasForeignKey(x => x.IdCliente)
               .IsRequired();

            modelBuilder
              .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
