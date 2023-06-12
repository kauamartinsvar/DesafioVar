using System;
using System.Collections.Generic;
using System.Text;

namespace ContaPessoa.Repository.Models
{
    public class Tab_Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public string Genero { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }
    }
}
