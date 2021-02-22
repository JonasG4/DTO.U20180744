using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO.U20180744.Models
{
    public class Notas : EntityBase
    {
        [Required]
        public String IdMateria { get; set; }
        public Materia Materia { get; set; }
        public String IdAlumno { get; set; }
        public Alumno Alumno { get; set; }
        public Decimal Nota { get; set; }
    }
}
