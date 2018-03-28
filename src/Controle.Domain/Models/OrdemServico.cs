using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class OrdemServico : Entity
    {
        public Equipamento Equipamento { get; protected set; }
        public Cliente Cliente { get; protected set; }

        public OrdemServico(Equipamento equipamento, Cliente cliente)
        {
                    
        }
    }
}
