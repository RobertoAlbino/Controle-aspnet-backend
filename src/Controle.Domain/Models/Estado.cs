using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Estado : Entity<Estado>
    {
        public string Nome { get; private set; }
        public int IdPais { get; private set; }

        #region Referência
        public virtual Pais Pais { get; set; }
        #endregion

        #region Navegação inversa
        public ICollection<Cidade> Cidade { get; set; }
        #endregion

        public Estado(string nome, int idPais)
        {
            Nome = nome;
            IdPais = idPais;
        }
    }
}
