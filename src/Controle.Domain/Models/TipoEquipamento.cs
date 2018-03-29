using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class TipoEquipamento : Entity<TipoEquipamento>
    {
        public string Nome { get; private set; }

        #region Navegação inversa
        public ICollection<Equipamento> Equipamento { get; set; }
        #endregion

        public TipoEquipamento(string nome)
        {
            Nome = nome;
        }
    }
}
