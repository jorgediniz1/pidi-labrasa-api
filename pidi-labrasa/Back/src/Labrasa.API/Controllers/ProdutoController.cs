using Labrasa.API.Domain.Interfaces;
using Labrasa.API.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labrasa.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _context;

        public ProdutoController(IProdutoRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.PegarTodos());
        }

        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            if (produto == null)
            {
                return BadRequest();
            }
            return Ok( await _context.Incluir(produto));
        }

        [HttpPut] //IMPLEMENTAR PUT


       [HttpDelete]
       public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _context.Apagar(id));
        }
    }
}
