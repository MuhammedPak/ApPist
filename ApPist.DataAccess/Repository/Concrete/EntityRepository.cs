using ApPist.DataAccess.Abstract;
using ApPist.Domain.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ApPist.DataAccess.Concrete
{
    public class EntityRepository<T> : IEntityRepository<T>
        where T : class, IBaseEntity

    {
        private ApPistDbContext context;
        public EntityRepository(ApPistDbContext _context)
        {
            context = _context;
        }

        public virtual void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
                     ? context.Set<T>().ToList()
                     : context.Set<T>().Where(filter).ToList();
        }

        public virtual T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual T GetOne(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).SingleOrDefault();
        }

        public virtual void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
