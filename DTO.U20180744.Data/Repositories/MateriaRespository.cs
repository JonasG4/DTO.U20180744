using DTO.U20180744.Data.Interfaces;
using DTO.U20180744.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.U20180744.Data.Repositories
{
    public class MateriaRespository : Repository<Materia>, IMateriaRepository
    {
        private readonly ApplicationDbContext _db;

        public MateriaRespository(ApplicationDbContext db) : base(db) { }
    }
}
