using Microsoft.EntityFrameworkCore;
using Controle.Domain.Models;

namespace Controle.Infra.Data.Context
{
    public class ControleContext : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<TipoEquipamento> TipoEquipamento { get; set; }
    }
}
