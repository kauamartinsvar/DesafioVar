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
        public IActionResult ObterDados()
        {
            var CorrenteService = new CorrenteService (_context);
            var correntes = CorrenteService.ObterDados();

            if (correntes == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(correntes);
            }
        }
    }
}
