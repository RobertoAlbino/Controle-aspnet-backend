using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Pais : Entity<Pais>
    {
        public string Nome { get; private set; }

        #region Navegação inversa
        public ICollection<Estado> Estado { get; set; }
        #endregion

        public Pais(string nome)
        {
            Nome = nome;
        }
    }
}
