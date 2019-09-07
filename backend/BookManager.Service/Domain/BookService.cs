using System.Collections.Generic;
using System.Linq;
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
            return t;
        }

        public Book Change (Book t) {
            return _repository.Update (t);
        }

        public IEnumerable<Book> GetAll () {
            var list = _repository.FindAll ().OrderByDescending (b => b.Id);
            return list;
        }

        public IEnumerable<Book> Search (string title = "", int authorId = 0) {
            var list = Enumerable.Empty<Book> ();

            if (authorId > 0 && title != "" && title != null) {
                list = _repository.Find (book => book.AuthorId == authorId && book.Title.Contains (title));
                return list;
            }

            if (authorId > 0) {
                list = _repository.Find (book => book.AuthorId == authorId);
                return list;
            }

            if (title != "") {
                list = _repository.Find (book => book.Title.Contains (title));
            }

            return list;
        }

        public Book GetById (int id) {
            return _repository.ById (id);
        }

        public void Remove (int id) {
            _repository.Delete (id);
        }
    }
}