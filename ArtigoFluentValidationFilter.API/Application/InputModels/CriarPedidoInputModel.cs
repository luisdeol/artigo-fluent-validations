using System.Collections.Generic;

namespace ArtigoFluentValidationFilter.API.Application.InputModels
{
    public class CriarPedidoInputModel
    {
        public int IdCliente { get; set; }
        public List<ProdutoInputModel> Produtos { get; set; }
        public List<CupomInputModel> Cupons { get; set; }
    }

    public class ProdutoInputModel
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
    }

    public class CupomInputModel
    {
       public string Codigo { get; set; }
    }
}
