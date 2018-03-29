using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Controle.Domain.Models;
using Controle.Infra.Data.Extensions;
using Controle.Infra.Data.Mappings;

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
            modelBuilder.AddConfiguration(new CidadeMapping());
            modelBuilder.AddConfiguration(new ClienteMapping());
            modelBuilder.AddConfiguration(new EnderecoMapping());
            modelBuilder.AddConfiguration(new EquipamentoMapping());
            modelBuilder.AddConfiguration(new EstadoMapping());
            modelBuilder.AddConfiguration(new OrdemServicoMapping());
            modelBuilder.AddConfiguration(new PaisMapping());
            modelBuilder.AddConfiguration(new TipoEquipamentoMapping());

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
