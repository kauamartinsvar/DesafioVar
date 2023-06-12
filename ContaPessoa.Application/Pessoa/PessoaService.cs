using ContaPessoa.Repository;
using ContaPessoa.Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ContaPessoa.Application.Pessoa
{
    public class PessoaService
    {
        private readonly PessoaContext _context;
        public PessoaService(PessoaContext context)
        {
            _context = context;
        }
        public bool InserirAlgo(PessoaRequest request)
        {
            try
            {
                var Pessoa = new Tab_Pessoa()
                {
                    Nome = request.Nome,
                    DataNascimento = request.DataNascimento,
                    Genero = request.Genero,
                    Endereco = request.Endereco,
                    Telefone = request.Telefone,
                    Email = request.Email,
                    CPF = request.CPF
                };
                _context.Pessoas.Add(Pessoa);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
        public List<Tab_Pessoa> ObterPessoas()
        {
            try
            {
                var pessoas = _context.Pessoas.ToList();
                return pessoas;
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public bool AtualizarPessoa(int id, PessoaRequest request)
        {
            try
            {
                var pessoaDb = _context.Pessoas.FirstOrDefault(x => x.ID == id);
                if (pessoaDb == null)
                    return false;

                pessoaDb.Nome = request.Nome;
                pessoaDb.DataNascimento = request.DataNascimento;
                pessoaDb.Genero = request.Genero;
                pessoaDb.Endereco = request.Endereco;
                pessoaDb.Telefone = request.Telefone;
                pessoaDb.Email = request.Email;
                pessoaDb.CPF = request.CPF;

                _context.Pessoas.Update(pessoaDb);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool RemoverPessoa(int id)
        {
            try
            {
                var pessoasDb = _context.Pessoas.FirstOrDefault(x => x.ID == id);
                if (pessoasDb == null)
                    return false;

                _context.Pessoas.Remove(pessoasDb);
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

