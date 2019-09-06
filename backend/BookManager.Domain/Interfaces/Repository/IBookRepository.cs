using BookManager.Domain.Models;

namespace BookManager.Domain.Interfaces.Repository {
    public interface IBookRepository : CRUDRepository<Book> {

    }
}