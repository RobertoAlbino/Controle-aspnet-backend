using System.Collections.Generic;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Equipamento : Entity<Equipamento>
    {
        public string Nome { get; private set; }
        public string Marca { get; private set; }
        public int IdTipoEquipamento { get; private set; }

        #region Referência 
        public virtual TipoEquipamento TipoEquipamento { get; set; }
        #endregion

        #region Navegação inversa
        public ICollection<OrdemServico> OrdemServico { get; set; }
        #endregion

        public Equipamento(string nome, string marca, int idTipoEquipamento)
        {
            Nome = nome;
            Marca = marca;
            IdTipoEquipamento = idTipoEquipamento;
        }
    }
}
