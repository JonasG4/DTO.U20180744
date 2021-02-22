using DTO.U20180744.Models;
using DTO.U20180744.TransferObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.U20180744.Mapper
{
    public class Mapper
    {
        public MejoresNotasDTO CreateDTO(Notas entity)
        {
            MejoresNotasDTO result = new MejoresNotasDTO
            {
                NombreCompleto = entity.Alumno.Nombres + " " + entity.Alumno.Apelllidos,
                Carrera = entity.Alumno.Carrera,
                Nota = entity.Nota
            };
            return result;
        }
    }
}
