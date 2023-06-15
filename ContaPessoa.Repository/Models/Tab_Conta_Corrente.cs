using System;
using System.Collections.Generic;
using System.Text;

namespace ContaPessoa.Repository.Models
{
    public class Tab_Conta_Corrente
    {
        public int Id { get; set; }
        public int Id_Pessoa { get; set; }

        public string Numero_Conta { get; set; }

     public decimal Saldo { get; set; }

    }
}
