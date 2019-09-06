using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Infra.Context;

namespace BookManager.Infra.Repository {
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository {
        public GenreRepository (BookManagerContext context) : base (context) { }
    }
}