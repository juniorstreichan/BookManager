using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;

namespace BookManager.Mock.Repository {
    public class AuthorRepository : IAuthorRepository {
        private List<Author> _data = new List<Author> {
            new Author { Id = 1, Name = "Matheus" },
            new Author { Id = 2, Name = "Marcos" },
            new Author { Id = 3, Name = "Lucas" },
            new Author { Id = 4, Name = "João" }
        };
        public Author ById (int id) {
            try {
                return _data.First (a => a.Id == id);
            } catch (System.Exception) {

                return null;
            }
        }

        public void Delete (int id) {
            var author = ById (id);

            if (author != null) {
                _data.Remove (author);
            }
        }

        public IQueryable<Author> Find (Expression<Func<Author, bool>> expression) {
            return _data.AsQueryable ().Where (expression);
        }

        public IEnumerable<Author> FindAll () {
            return _data;
        }

        public Author Insert (Author entity) {
            _data.Add (entity);
            return entity;
        }

        public Author Update (Author entity) {
            var author = ById (entity.Id);

            if (author != null) {
                _data.Remove (author);
                _data.Add (entity);
            }

            return ById (entity.Id);
        }
    }
}