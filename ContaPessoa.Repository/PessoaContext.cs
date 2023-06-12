using ContaPessoa.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ContaPessoa.Repository
{
    public class PessoaContext : DbContext  //PessoaContext está herdando o que tem dentro de DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options) { }
        public DbSet<Tab_Pessoa> Pessoas { get; set; }
        public DbSet<Tab_Conta_Corrente> Corrente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tab_Pessoa>().ToTable("Tab_Pessoa");
            modelBuilder.Entity<Tab_Conta_Corrente>().ToTable("Tab_Conta_Corrente");
        }
    }
}