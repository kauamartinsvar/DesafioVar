using ContaPessoa.Repository;
using ContaPessoa.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaPessoa.Application.Corrente
{
    public class CorrenteService
    {
        private readonly PessoaContext _context;
        public CorrenteService(PessoaContext context)
        {
            _context = context;
        }
        public List<Tab_Conta_Corrente> ObterContaCorrente()
        {
            try
            {
                var corrente = _context.Corrente.ToList();
                return corrente;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        public Tab_Conta_Corrente ObterSaldo(int id)
        {
            try
            {
                var saldo = _context.Corrente.FirstOrDefault(x => x.Id == id);
                if (saldo != null)
                {
                    var saldoConta = new Tab_Conta_Corrente
                    {
                        Id = saldo.Id,
                        Saldo = saldo.Saldo
                    };
                    return saldoConta;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception Ex)
            {
                return null;
            }
        }
        




    }
}
