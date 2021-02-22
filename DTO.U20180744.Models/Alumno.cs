using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.U20180744.Models
{
    public class Alumno : EntityBase
    {
        public String Nombres { get; set; }
        public String Apelllidos { get; set; }
        public int Edad { get; set; }
        public String Carrera { get; set; }

        public ICollection<Notas> Notas { get; set; }
    }
}
