using Controle.Domain.Core.Models;
using FluentValidation;

namespace Controle.Domain.Models
{
    public class OrdemServico : Entity<OrdemServico>
    {
        public Equipamento Equipamento { get; private set; }
        public Cliente Cliente { get; private set; }
        public string Problema { get; private set; }

        public OrdemServico(Equipamento equipamento, Cliente cliente, string problema)
        {
            Equipamento = equipamento;
            Cliente = cliente;
            Problema = problema;

            ValidarEntidade();
        }

        public override bool ValidarEntidade()
        {
            ValidarEquipamento();
            ValidarCliente();
            ValidarProblema();
            ValidationResult = Validate(this);
        }

        public void ValidarEquipamento()
        {
            RuleFor(x => x.Equipamento)
                .NotNull()
                .WithMessage("O equipamento não pode ser nulo.");
        }

        public void ValidarCliente()
        {
            RuleFor(x => x.Cliente)
                .NotNull()
                .WithMessage("O cliente não pode ser nulo.");
        }

        public void ValidarProblema()
        {
            RuleFor(x => x.Problema)
                .NotNull()
                .NotEmpty()
                .WithMessage("O problema não pode ser nulo.");
        }


    }
}
