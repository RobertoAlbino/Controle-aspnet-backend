using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Pais : Entity
    {
        public string Nome { get; protected set; }

        public Pais(string nome)
        {
            Nome = nome;
        }
    }
}
