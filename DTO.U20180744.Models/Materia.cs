using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO.U20180744.Models
{
    public class Materia : EntityBase
    {
        [Required]
        [MinLength(5, ErrorMessage = "El número de carácteres debe ser mayor a 5")]
        public string NombreMateria { get; set; }
        [Required]
        public int Creditos { get; set; }

        public ICollection<Notas> Notas { get; set; }

    }
}
