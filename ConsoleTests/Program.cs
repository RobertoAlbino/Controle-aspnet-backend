using System;
using Controle.Domain.Models;

namespace ConsoleTests
{
    class Program
    {
        public static void Main(string[] args)
        {
            var ordemServico = new OrdemServico(new Equipamento("","", new TipoEquipamento("")), 
                                                new Cliente("","","",
                                                new Endereco(new Pais(""), new Estado(""), new Cidade(""), "", "", "")), "");
        }
    }
}
