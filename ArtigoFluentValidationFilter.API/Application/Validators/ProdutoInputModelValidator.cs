using ArtigoFluentValidationFilter.API.Application.InputModels;
using FluentValidation;

namespace ArtigoFluentValidationFilter.API.Application.Validators
{
    public class ProdutoInputModelValidator : AbstractValidator<ProdutoInputModel>
    {
        public ProdutoInputModelValidator()
        {
            RuleFor(pim => pim.Id)
                .GreaterThan(0)
                .WithMessage("Id inválido para produto");

            RuleFor(pim => pim.Quantidade)
                .GreaterThan(0)
                .WithMessage("Quantidade inválida para produto.");
        }
    }
}
