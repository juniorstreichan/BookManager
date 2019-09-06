using BookManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Infra.Context {
    public class BookManagerContext : DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public BookManagerContext (DbContextOptions<BookManagerContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<BookGenre> ()
                .HasKey (bg => new { bg.BookId, bg.GenreId });
        }
    }
}