using System.Collections.Generic;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;

namespace BookManager.Service.Domain {
    public class GenreService : IGenreService {

        private readonly IGenreRepository _repository;

        public GenreService (IGenreRepository repository) {
            _repository = repository;
        }

        public Genre Add (Genre t) {
            return _repository.Insert (t);
        }

        public Genre Change (Genre t) {
            return _repository.Update (t);
        }

        public IEnumerable<Genre> GetAll () {
            return _repository.FindAll ();
        }

        public Genre GetById (int id) {
            return _repository.ById (id);
        }

        public void Remove (int id) {
            _repository.Delete (id);
        }
  }
}