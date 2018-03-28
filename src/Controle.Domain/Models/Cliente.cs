using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Telefone { get; protected set; }
        public Endereco Endereco { get; protected set; }
    }
}
