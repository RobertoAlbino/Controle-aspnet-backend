using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Endereco : Entity
    {
        public Pais Pais { get; protected set; }
        public Estado Estado { get; protected set; }
        public Cidade Cidade { get; protected set; }
        public string Bairro { get; protected set; }        
        public string Rua { get; protected set; }
        public string CEP { get; protected set; }
    }
}
