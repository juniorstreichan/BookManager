using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Infra.Context;

namespace BookManager.Infra.Repository {
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository {
        public AuthorRepository (BookManagerContext context) : base (context) { }
    }
}