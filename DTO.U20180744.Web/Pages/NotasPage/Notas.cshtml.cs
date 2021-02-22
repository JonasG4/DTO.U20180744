using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.U20180744.Data.Interfaces;
using DTO.U20180744.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DTO.U20180744.Web.Pages.NotasPage
{
    public class NotasModel : PageModel
    {
        private readonly INotasRepository _notasRespository;

        public NotasModel(INotasRepository notasRespository)
        {
            _notasRespository = notasRespository;
        }

        [BindProperty]
        public IEnumerable<Notas> Notas { get; set; }

        public IActionResult OnGet()
        {
            Notas = _notasRespository.List();
            return Page();
        }
    }
}
