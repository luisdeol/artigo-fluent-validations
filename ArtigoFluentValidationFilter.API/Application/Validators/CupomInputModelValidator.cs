using ArtigoFluentValidationFilter.API.Application.InputModels;
using FluentValidation;

namespace ArtigoFluentValidationFilter.API.Application.Validators
{
    public class CupomInputModelValidator : AbstractValidator<CupomInputModel>
    {
        public CupomInputModelValidator()
        {
            RuleFor(cim => ValidarFormatoCupom(cim.Codigo))
                .Equal(true)
                .WithMessage("Cupom em formato inválido");        
        }

        public bool ValidarFormatoCupom(string codigo)
        {
            return codigo.Length == 10;
        }
    }
}
