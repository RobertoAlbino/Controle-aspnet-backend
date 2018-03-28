using System;
using Controle.Domain.Core.Models;

namespace Controle.Domain.Models
{
    public class Endereco : Entity<Endereco>
    {
        public Pais Pais { get; private set; }
        public Estado Estado { get; private set; }
        public Cidade Cidade { get; private set; }
        public string Bairro { get; private set; }        
        public string Rua { get; private set; }
        public string CEP { get; private set; }

        public Endereco(Pais pais, Estado estado, Cidade cidade, string bairro, string rua, string cep)
        {
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            CEP = cep;

            ValidarEntidade();
        }
    }
}
