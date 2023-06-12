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
        public List<Tab_Conta_Corrente> ObterDados()
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





    }
}
