using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Estado : Entity
    {
        public string Nome { get; protected set; }

        public Estado(string nome)
        {
            Nome = nome;
        }
    }
}
