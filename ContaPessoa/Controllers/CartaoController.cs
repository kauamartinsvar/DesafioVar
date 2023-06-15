using ContaPessoa.Application.Cartao;
using ContaPessoa.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using ContaPessoa.Application.Pessoa;

namespace ContaPessoa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartaoController : ControllerBase
    {
        private readonly PessoaContext _context;
        public CartaoController(PessoaContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult ObterCartao([FromRoute] int id)
        {
            var cartaoService = new CartaoService(_context);
            var cartao = cartaoService.ObterCartaoPorId(id);

            if (cartao == null)
            {
                return NotFound(); 
            }
            else
            {
                return Ok(cartao);
            }
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult RemoverCartoes([FromRoute] int id)// id so de exemplo mas não vai ser id
        {
            var CartaoService = new CartaoService(_context);
            var sucesso = CartaoService.RemoverCartao(id);

            if (sucesso == true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult AtualizarCartoes([FromRoute] int id, [FromBody] CartaoRequest request)
        {
            var cartaoService = new CartaoService(_context);
            var sucesso = cartaoService.AtualizarCartao(id, request);

            if (sucesso == true)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
