using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.U20180744.Data.Interfaces;
using DTO.U20180744.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DTO.U20180744.Web.Pages.MateriaPage
{
    public class MateriaModel : PageModel
    {
        private readonly IMateriaRepository _materiaRespository;

        public MateriaModel(IMateriaRepository materiaRespository)
        {
            _materiaRespository = materiaRespository;
        }

        [BindProperty]
        public IEnumerable<Materia> Materias { get; set; }

        public IActionResult OnGet()
        {
            Materias = _materiaRespository.List();
            return Page();
        }
    }
}
