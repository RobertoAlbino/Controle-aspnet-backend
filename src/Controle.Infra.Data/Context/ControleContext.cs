using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Controle.Infra.Data.Context
{
    public class ControleContext : DbContext
    {
        #region Entidades
        public DbSet<Cidade> Cidades { get; set; }
       // public DbSet<Cliente> Clientes { get; set; }
       // public DbSet<Endereco> Enderecos { get; set; }
        //public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        //public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Pais> Pais { get; set; }
        //public DbSet<TipoEquipamento> TipoEquipamento { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Cidade
            modelBuilder.Entity<Cidade>()
                .ToTable("Cidades")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Cidade>()
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder.Entity<Cidade>()
               .Ignore(x => x.ValidationResult);
            #endregion

            #region Cliente
            modelBuilder.Entity<Cliente>()
                .ToTable("Clientes")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Cliente>()
                .Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .Ignore(x => x.Endereco);

            modelBuilder.Entity<Cliente>()
                .Property(x => x.Telefone)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
              .Ignore(x => x.ValidationResult);
            #endregion

            #region Estado
            modelBuilder.Entity<Estado>()
                .ToTable("Estados")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Estado>()
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder.Entity<Estado>()
              .Ignore(x => x.ValidationResult);
            #endregion

            #region Pais
            modelBuilder.Entity<Pais>()
                .ToTable("Paises")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Pais>()
                .Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Pais>()
              .Ignore(x => x.ValidationResult);
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Connection"));
        }

    }
}
