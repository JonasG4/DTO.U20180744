using DTO.U20180744.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DTO.U20180744.Data.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);

        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
