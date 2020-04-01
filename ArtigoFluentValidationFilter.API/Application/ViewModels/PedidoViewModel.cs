using System;
using System.Collections.Generic;

namespace ArtigoFluentValidationFilter.API.Application.ViewModels
{
    public class PedidoViewModel
    {
        public PedidoViewModel(int id, decimal total, List<ProdutoViewModel> produtos, DateTime dataCriacao)
        {
            Id = id;
            Total = total;
            Produtos = produtos;
            DataCriacao = dataCriacao;
        }

        public int Id { get; set; }
        public decimal Total { get; set; }
        public List<ProdutoViewModel> Produtos { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
