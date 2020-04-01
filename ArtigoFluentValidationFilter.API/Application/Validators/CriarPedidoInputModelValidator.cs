using ArtigoFluentValidationFilter.API.Application.InputModels;
using FluentValidation;

namespace ArtigoFluentValidationFilter.API.Application.Validators
{
    public class CriarPedidoInputModelValidator : AbstractValidator<CriarPedidoInputModel>
    {
        public CriarPedidoInputModelValidator()
        {
            RuleFor(cp => cp.IdCliente)
                .GreaterThan(0)
                .WithMessage("IdCliente tem que ser um valor válido");

            // SetCollectionValidator é necessário para esses casos quando um objeto contém outros objetos em sua estrutura
            // Em caso de que não fosse uma lista e sim um objeto, se utilizaria SetValidator
            RuleFor(cp => cp.Produtos)
                .NotNull()
                .NotEmpty()
                .WithMessage("Produtos não pode ser null ou vazio.")
                .SetCollectionValidator(new ProdutoInputModelValidator());

            RuleFor(cp => cp.Cupons)
                .NotNull()
                .WithMessage("Cupons não pode ser null.")
                .SetCollectionValidator(new CupomInputModelValidator());
        }
    }
}
