using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Estado : Entity<Estado>
    {
        public string Nome { get; private set; }

        public Estado(string nome)
        {
            Nome = nome;
        }
    }
}
