using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;

namespace BookManager.Mock.Repository {
    public class GenreRepository : IGenreRepository {

        private List<Genre> _data = new List<Genre> {
            new Genre { Id = 1, Description = "Épico" },
            new Genre { Id = 2, Description = "Fábula" },
            new Genre { Id = 3, Description = "Epopeia" },
            new Genre { Id = 4, Description = "Novela" }
        };

        public Genre ById (int id) {
            try {
                return _data.First (a => a.Id == id);
            } catch (System.Exception) {
                return null;
            }
        }

        public void Delete (int id) {
            var obj = ById (id);

            if (obj != null) {
                _data.Remove (obj);
            }
        }

        public IQueryable<Genre> Find (Expression<Func<Genre, bool>> expression) {
            return _data.AsQueryable ().Where (expression);
        }

        public IEnumerable<Genre> FindAll () {
            return _data;
        }

        public Genre Insert (Genre entity) {
            _data.Add (entity);
            return entity;
        }

        public Genre Update (Genre entity) {
            var obj = ById (entity.Id);

            if (obj != null) {
                _data.Remove (obj);
                _data.Add (entity);
            }

            return ById (entity.Id);
        }

    }
}