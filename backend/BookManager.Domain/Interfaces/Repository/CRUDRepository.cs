using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BookManager.Domain.Interfaces.Repository {
    public interface CRUDRepository<T> {
        T Insert (T entity);
        T Update (T entity);
        T ById (int id);
        void Delete (int id);
        IQueryable<T> Find (Expression<Func<T, bool>> expression);
        IEnumerable<T> FindAll ();

    }
}