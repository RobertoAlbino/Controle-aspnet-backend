using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Cliente : Entity<Cliente>
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public Endereco Endereco { get; private set; }

        public Cliente(string nome, string email, string telefone, Endereco endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
