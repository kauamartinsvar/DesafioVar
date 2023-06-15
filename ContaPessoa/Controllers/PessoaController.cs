using ContaPessoa.Application.Pessoa;
using ContaPessoa.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContaPessoa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaContext _context;
        public PessoaController(PessoaContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult InserirAlgo([FromBody] PessoaRequest request)
        {
            var pessoaService = new PessoaService(_context);
            var sucesso = pessoaService.InserirAlgo(request);
            
            if (sucesso == true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult ObterPessoas()
        {
            var pessoaService = new PessoaService(_context);
            var pessoa = pessoaService.ObterPessoas();
            
            if(pessoa == null)
            {
                return BadRequest();
            }
            else
            { 
             return Ok(pessoa); 
            }
        }
        

       

    }
}
