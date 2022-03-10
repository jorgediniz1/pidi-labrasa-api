using Labrasa.API.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Labrasa.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ComandaController : Controller
    {
        private readonly IComandaRepository _context;

        public ComandaController(IComandaRepository context)
        {
            _context = context;
        }
    }
}
