c

namespace Controle.Domain.Models
{
    public class Cidade
    {
        public string Nome { get; protected set; }

        public Cidade(string nome)
        {
            Nome = nome;
        }
    }
}
