using ArtigoFluentValidationFilter.API.Application.InputModels;
using ArtigoFluentValidationFilter.API.Application.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ArtigoFluentValidationFilter.API.Application.Services
{
    public class PedidoService : IPedidoService
    {
        public Task<PedidoViewModel> ProcessarPedido(CriarPedidoInputModel criarPedidoInputModel)
        {
            var random = new Random();
            var id = random.Next(1, 10);

            var produtosViewModel = criarPedidoInputModel.Produtos.Select(p => new ProdutoViewModel(p.Id, p.Quantidade)).ToList();

            var quantidadeTotal = produtosViewModel.Sum(p => p.Quantidade);
            var precoUnicoItem = random.Next(5, 50);

            var precoTotal = quantidadeTotal * precoUnicoItem;

            var pedidoViewModel = new PedidoViewModel(id, precoTotal,  produtosViewModel, DateTime.Now);

            return Task.FromResult(pedidoViewModel);
        }
    }
}
