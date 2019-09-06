using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Infra.Repository {
    public abstract class BaseRepository<T> : CRUDRepository<T> where T : class {
        protected readonly BookManagerContext _context;
        protected readonly DbSet<T> _db;

        public BaseRepository (BookManagerContext context) {
            _context = context;
            _db = _context.Set<T> ();
        }

        public T ById (int id) {
            return _db.Find (id);
        }

        public void Delete (int id) {
            var entity = ById (id);
            _db.Remove (entity);
            _context.SaveChanges ();
        }

        public IQueryable<T> Find (Expression<Func<T, bool>> expression) {
            return _db.Where (expression);
        }

        public IEnumerable<T> FindAll () {
            return _db.AsEnumerable ();
        }

        public T Insert (T entity) {
            _db.Add (entity);
            _context.SaveChanges ();
            return entity;
        }

        public T Update (T entity) {
            _db.Update (entity);
            _context.SaveChanges ();
            return entity;
        }
    }
}