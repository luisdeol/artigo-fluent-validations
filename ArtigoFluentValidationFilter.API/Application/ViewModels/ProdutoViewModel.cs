namespace ArtigoFluentValidationFilter.API.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel(int id, int quantidade)
        {
            Id = id;
            Quantidade = quantidade;
        }

        public int Id { get; set; }
        public int Quantidade { get; set; }
    }
}
