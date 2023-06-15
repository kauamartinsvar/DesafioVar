using ContaPessoa.Application.Corrente;
using ContaPessoa.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContaPessoa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorrenteController : ControllerBase
    {
        private readonly PessoaContext _context;
        public CorrenteController(PessoaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ObterContaCorrente()
        {
            var CorrenteService = new CorrenteService (_context);
            var correntes = CorrenteService.ObterContaCorrente();

            if (correntes == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(correntes);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult ObterSaldoConta([FromRoute] int id)
        {
            var CorrenteService = new CorrenteService(_context);
            var saldoConta = CorrenteService.ObterSaldo(id);

            if (saldoConta == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(saldoConta);
            }
        }
    }
}
