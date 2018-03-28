using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Equipamento : Entity<Equipamento>
    {
        public string Nome { get; private set; }
        public string Marca { get; private set; }
        public TipoEquipamento TipoEquipamento { get; private set; }

        public Equipamento(string nome, string marca, TipoEquipamento tipoEquipamento)
        {
            Nome = nome;
            Marca = marca;
            TipoEquipamento = tipoEquipamento;
        }
    }
}
