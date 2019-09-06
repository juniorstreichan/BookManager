using System.Collections.Generic;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;

namespace BookManager.Service.Domain {
    public class BookService : IBookService {
        private readonly IBookRepository _repository;

        public BookService (IBookRepository repository) {
            _repository = repository;
        }

        public virtual Book Add (Book t) {
            _repository.Insert (t);
            foreach (var item in t.BookGenres)
            {
                item.BookId = t.Id;
            }
            _repository.Update(t);
            return t;
        }

        public Book Change (Book t) {
            return _repository.Update (t);
        }

        public IEnumerable<Book> GetAll () {
            return _repository.FindAll ();
        }

        public Book GetById (int id) {
            return _repository.ById (id);
        }

        public void Remove (int id) {
            _repository.Delete (id);
        }
    }
}