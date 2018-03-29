using System;
using System.Collections.Generic;
using Controle.Domain.Core.Models;
using FluentValidation;
using FluentValidation.Results;

namespace Controle.Domain.Models
{
    public class OrdemServico : Entity<OrdemServico>
    {
        public int IdEquipamento { get; private set; }
        public int IdCliente { get; private set; }
        public string Problema { get; private set; }
        public bool Atendida { get; private set; }

        #region Referência
        public virtual Equipamento Equipamento { get; set; }
        public virtual Cliente Cliente { get; set; }
        #endregion

        public OrdemServico(int idEquipamento, int idCliente, string problema, bool atendida)
        {
            IdEquipamento = idEquipamento;
            IdCliente = idCliente;
            Problema = problema;
            Atendida = atendida;

            var validacao = ValidarEntidade(); 
            if (!validacao.IsValid)
            {
                // TODO: Criar uma lista de erros
                throw new Exception("A entidade não foi criada corretamente.");
            }
        }

        public override ValidationResult ValidarEntidade()
        {
            ValidarEquipamento();
            ValidarCliente();
            ValidarProblema();
            return ValidationResult = Validate(this);
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
