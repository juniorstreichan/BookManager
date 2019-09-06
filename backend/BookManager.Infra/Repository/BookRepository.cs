using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Infra.Context;

namespace BookManager.Infra.Repository {
    public class BookRepository : BaseRepository<Book>, IBookRepository {
        public BookRepository (BookManagerContext context) : base (context) { }
    }
}