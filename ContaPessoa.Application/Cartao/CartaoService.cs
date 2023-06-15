using ContaPessoa.Application.Pessoa;
using ContaPessoa.Repository;
using ContaPessoa.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContaPessoa.Application.Cartao
{
   
   
    public class CartaoService
    {
        private readonly PessoaContext _context;
        public CartaoService (PessoaContext context)
        {
            _context = context;
        }
        public Tab_Cartao ObterCartaoPorId(int cartaoId)
        {
            try
            {
                var cartao = _context.Cartao.FirstOrDefault(x => x.ID == cartaoId);
                return cartao;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool RemoverCartao(int id)
        {
            try
            {
                var idcartao = _context.Cartao.FirstOrDefault(x => x.ID == id);
                if (idcartao == null)
                    return false;

                _context.Cartao.Remove(idcartao);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AtualizarCartao(int id, CartaoRequest request)
        {
            try
            {
                var idcartao = _context.Cartao.FirstOrDefault(x => x.ID == id);
                if (idcartao == null)
                    return false;

                idcartao.Numero_Cartao = request.Numero_Cartao;
                idcartao.Data_Validade = request.Data_Validade;
                idcartao.Cvv = request.Cvv;
                

                _context.Cartao.Update(idcartao);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
