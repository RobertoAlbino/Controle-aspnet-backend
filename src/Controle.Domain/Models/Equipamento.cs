using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Equipamento : Entity
    {
        public string Nome { get; protected set; }
        public string Marca { get; protected set; }
    }
}
