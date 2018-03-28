using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Pais : Entity<Pais>
    {
        public string Nome { get; private set; }

        public Pais(string nome)
        {
            Nome = nome;
        }
    }
}
