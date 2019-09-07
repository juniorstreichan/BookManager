using System.Collections.Generic;
using BookManager.Domain.Models;

namespace BookManager.Domain.Interfaces.Service {
    public interface IBookService : CRUDService<Book> {
        IEnumerable<Book> Search (string title = "", int authorId = 0, int genreId = 0);

    }
}