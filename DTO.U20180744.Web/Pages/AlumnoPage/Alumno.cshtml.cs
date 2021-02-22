using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.U20180744.Data.Interfaces;
using DTO.U20180744.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DTO.U20180744.Web.Pages.AlumnoPage
{
    public class AlumnoModel : PageModel
    {
        private readonly IAlumnoRepository _alumnoRespository;

        public AlumnoModel(IAlumnoRepository alumnoRespository)
        {
            _alumnoRespository = alumnoRespository;
        }

        [BindProperty]
        public IEnumerable<Alumno> Alumnos { get; set; }

        public IActionResult OnGet()
        {
            Alumnos = _alumnoRespository.List();
            return Page();
        }
    }
}
