using System.Collections.Generic;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;

namespace BookManager.Service.Domain {
    public class AuthorService : IAuthorService {
        private readonly IAuthorRepository _repository;

        public AuthorService (IAuthorRepository repository) {
            _repository = repository;
        }

        public Author Add (Author t) {
            return _repository.Insert (t);
        }

        public Author Change (Author t) {
            return _repository.Update (t);
        }

        public IEnumerable<Author> GetAll () {
            return _repository.FindAll ();
        }

        public Author GetById (int id) {
            return _repository.ById (id);
        }

        public void Remove (int id) {
            _repository.Delete (id);
        }
    }
}