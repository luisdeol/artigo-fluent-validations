using ArtigoFluentValidationFilter.API.Application.InputModels;
using ArtigoFluentValidationFilter.API.Application.ViewModels;
using System.Threading.Tasks;

namespace ArtigoFluentValidationFilter.API.Application.Services
{
    public interface IPedidoService
    {
        Task<PedidoViewModel> ProcessarPedido(CriarPedidoInputModel criarPedidoInputModel);
    }
}
