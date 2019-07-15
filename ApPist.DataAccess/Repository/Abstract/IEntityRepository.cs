using ApPist.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApPist.DataAccess.Abstract
{

    public interface IEntityRepository<T> where T : IBaseEntity
    {

        T GetById(int id);
        T GetOne(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
