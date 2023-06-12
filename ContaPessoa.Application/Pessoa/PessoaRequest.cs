using System;
using System.Collections.Generic;
using System.Text;

namespace ContaPessoa.Application.Pessoa
{
    public class PessoaRequest
    {

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public string Genero { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; } 

        public string Email { get; set; }

        public string CPF { get; set; }

    }
}
