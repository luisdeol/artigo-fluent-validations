using ArtigoFluentValidationFilter.API.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace ArtigoFluentValidationFilter.API.Filters
{
    public class ModelStateValidatorFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = new ErrosViewModel(context.ModelState.GetErrorsMessages());

                context.Result = new BadRequestObjectResult(errors);
            }
        }
    }

    // Classe e método de extensão para deixar o código mais limpo. Idealmente essa classe ficaria em uma pasta "Extensions" no projeto da API.
    public static class ModelStateExtensions
    {
        public static List<string> GetErrorsMessages(this ModelStateDictionary modelState)
        {
            return modelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
        }
    }
}
