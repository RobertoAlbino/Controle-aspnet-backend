using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Cidade : Entity<Cidade>
    {
        public string Nome { get; private set; }
        public int IdEstado { get; private set; }

        #region Referência
        public virtual Estado Estado { get; set; }
        #endregion

        #region Navegação inversa
        public ICollection<Endereco> Endereco { get; set; }
        #endregion

        public Cidade(string nome, int idEstado)
        {
            Nome = nome;
            IdEstado = IdEstado;
        }
    }
}
