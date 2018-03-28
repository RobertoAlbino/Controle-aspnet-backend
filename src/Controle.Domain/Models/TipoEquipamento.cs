using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class TipoEquipamento : Entity<TipoEquipamento>
    {
        public string Nome { get; private set; }

        public TipoEquipamento(string nome)
        {
            Nome = nome;
        }
    }
}
