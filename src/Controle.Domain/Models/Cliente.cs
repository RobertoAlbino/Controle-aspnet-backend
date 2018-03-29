using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Cliente : Entity<Cliente>
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public int IdEndereco { get; private set; }

        #region Referência
        public virtual Endereco Endereco { get; private set; }
        #endregion

        #region Navegação inversa
        public ICollection<OrdemServico> OrdemServico { get; set; }
        #endregion

        public Cliente(string nome, string email, string telefone, int idEndereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            IdEndereco = idEndereco;
        }
    }
}
