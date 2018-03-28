using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Cidade : Entity<Cidade>
    {
        public string Nome { get; private set; }

        public Cidade(string nome)
        {
            Nome = nome;
        }
    }
}
