using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class TipoEquipamento : Entity
    {
        public string Nome { get; protected set; }

        public TipoEquipamento(string nome)
        {
            Nome = nome;
        }
    }
}
