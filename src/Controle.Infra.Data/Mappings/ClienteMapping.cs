using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;

namespace Controle.Infra.Data.Mappings
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public override void Map(EntityTypeBuilder<Cliente> modelBuilder)
        {
            modelBuilder
               .ToTable("Clientes")
               .HasKey(x => x.Id);

            modelBuilder
                .Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder
                .Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder
                .Property(x => x.Telefone)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder
                .HasOne(x => x.Endereco)
                .WithMany(x => x.Cliente)
                .HasForeignKey(x => x.IdEndereco)
                .IsRequired();

            modelBuilder
              .Ignore(x => x.ValidationResult);

            modelBuilder
              .Ignore(x => x.CascadeMode);
        }
    }
}
