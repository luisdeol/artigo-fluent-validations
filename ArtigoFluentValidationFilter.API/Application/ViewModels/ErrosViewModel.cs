using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtigoFluentValidationFilter.API.Application.ViewModels
{
    public class ErrosViewModel
    {
        public ErrosViewModel(List<string> erros)
        {
            Erros = erros;
        }

        public List<string> Erros { get; set; }
    }
}
