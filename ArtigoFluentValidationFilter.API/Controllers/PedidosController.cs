using ArtigoFluentValidationFilter.API.Application.InputModels;
using ArtigoFluentValidationFilter.API.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArtigoFluentValidationFilter.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        public PedidosController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CriarPedidoInputModel criarPedidoInputModel)
        {
            var pedidoViewModel = await _pedidoService.ProcessarPedido(criarPedidoInputModel);

            return Ok();
        }

        //[HttpGet("{idPedido}")]
        //public async Task<IActionResult> Get(int idPedido)
        //{
        //    return Ok(Task.CompletedTask);
        //}
    }
}
