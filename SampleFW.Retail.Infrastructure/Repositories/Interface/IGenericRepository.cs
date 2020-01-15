using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SampleFW.Retail.Infrastructure
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetByAll();

        IEnumerable<TEntity> GetByAll(Expression<Func<TEntity,bool>> expression);

        TEntity GetByID(object Id);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void Dispose();

    }
}
