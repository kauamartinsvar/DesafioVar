using System;
using System.Collections.Generic;
using System.Text;

namespace ContaPessoa.Application.Cartao
{
    public class CartaoRequest
    {
        public string Numero_Cartao { get; set; }
        public DateTime Data_Validade { get; set; }
        public int Cvv { get; set; }

    }
}
