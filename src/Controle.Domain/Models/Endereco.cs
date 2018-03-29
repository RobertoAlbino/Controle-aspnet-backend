using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Endereco : Entity<Endereco>
    {
        public int IdCidade { get; private set; }
        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string CEP { get; private set; }

        #region Referência
        public virtual Cidade Cidade { get; set; }
        #endregion

        #region Navegação inversa
        public ICollection<Cliente> Cliente { get; set; }
        #endregion

        public Endereco(int idCidade, string bairro, string rua, string cep)
        {
            IdCidade = idCidade;
            Bairro = bairro;
            Rua = rua;
            CEP = cep;

            ValidarEntidade();
        }
    }
}
