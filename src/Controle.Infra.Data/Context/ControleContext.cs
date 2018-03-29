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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<TipoEquipamento> TipoEquipamento { get; set; }
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
                .HasOne(x => x.Estado)
                .WithMany(x => x.Cidade)
                .HasForeignKey(x => x.IdEstado)
                .IsRequired();

            modelBuilder.Entity<Cidade>()
               .Ignore(x => x.ValidationResult);

            modelBuilder.Entity<Cidade>()
              .Ignore(x => x.CascadeMode);
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
                .Property(x => x.Telefone)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
                .HasOne(x => x.Endereco)
                .WithMany(x => x.Cliente)
                .HasForeignKey(x => x.IdEndereco)
                .IsRequired();

            modelBuilder.Entity<Cliente>()
              .Ignore(x => x.ValidationResult);

            modelBuilder.Entity<Cliente>()
              .Ignore(x => x.CascadeMode);
            #endregion

            #region Endereco
            modelBuilder.Entity<Endereco>()
              .ToTable("Enderecos")
              .HasKey(x => x.Id);

            modelBuilder.Entity<Endereco>()
                .Property(x => x.CEP)
                .HasColumnType("varchar(8)")
                .IsRequired();

            modelBuilder.Entity<Endereco>()
               .Property(x => x.Rua)
               .HasColumnType("varchar(150)")
               .IsRequired();

            modelBuilder.Entity<Endereco>()
               .Property(x => x.Bairro)
               .HasColumnType("varchar(150)")
               .IsRequired();

            modelBuilder.Entity<Endereco>()
                .HasOne(x => x.Cidade)
                .WithMany(x => x.Endereco)
                .HasForeignKey(x => x.IdCidade)
                .IsRequired();

            modelBuilder.Entity<Endereco>()
              .Ignore(x => x.ValidationResult);

            modelBuilder.Entity<Endereco>()
              .Ignore(x => x.CascadeMode);
            #endregion

            #region Equipamento
            modelBuilder.Entity<Equipamento>()
              .ToTable("Equipamentos")
              .HasKey(x => x.Id);

            modelBuilder.Entity<Equipamento>()
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder.Entity<Equipamento>()
               .Property(x => x.Marca)
               .HasColumnType("varchar(150)")
               .IsRequired();

            modelBuilder.Entity<Equipamento>()
                .HasOne(x => x.TipoEquipamento)
                .WithMany(x => x.Equipamento)
                .HasForeignKey(x => x.IdTipoEquipamento)
                .IsRequired();

            modelBuilder.Entity<Equipamento>()
              .Ignore(x => x.ValidationResult);

            modelBuilder.Entity<Equipamento>()
              .Ignore(x => x.CascadeMode);
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
                .HasOne(x => x.Pais)
                .WithMany(x => x.Estado)
                .HasForeignKey(x => x.IdPais)
                .IsRequired();

            modelBuilder.Entity<Estado>()
              .Ignore(x => x.ValidationResult);

            modelBuilder.Entity<Estado>()
              .Ignore(x => x.CascadeMode);
            #endregion

            #region OrdemServico
            modelBuilder.Entity<OrdemServico>()
               .ToTable("OrdemServico")
               .HasKey(x => x.Id);

            modelBuilder.Entity<OrdemServico>()
                .Property(x => x.Problema)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder.Entity<OrdemServico>()
                .Property(x => x.Atendida)
                .IsRequired();

            modelBuilder.Entity<OrdemServico>()
                .HasOne(x => x.Equipamento)
                .WithMany(x => x.OrdemServico)
                .HasForeignKey(x => x.IdEquipamento)
                .IsRequired();

            modelBuilder.Entity<OrdemServico>()
               .HasOne(x => x.Cliente)
               .WithMany(x => x.OrdemServico)
               .HasForeignKey(x => x.IdCliente)
               .IsRequired();

            modelBuilder.Entity<OrdemServico>()
              .Ignore(x => x.ValidationResult);

            modelBuilder.Entity<OrdemServico>()
              .Ignore(x => x.CascadeMode);
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

            modelBuilder.Entity<Pais>()
              .Ignore(x => x.CascadeMode);
            #endregion

            #region TipoEquipamento
            modelBuilder.Entity<TipoEquipamento>()
              .ToTable("TiposEquipamento")
              .HasKey(x => x.Id);

            modelBuilder.Entity<TipoEquipamento>()
                .Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            modelBuilder.Entity<TipoEquipamento>()
              .Ignore(x => x.ValidationResult);

            modelBuilder.Entity<TipoEquipamento>()
              .Ignore(x => x.CascadeMode);
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
