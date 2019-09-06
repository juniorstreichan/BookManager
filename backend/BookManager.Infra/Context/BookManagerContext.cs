using BookManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Infra.Context {
    public class BookManagerContext : DbContext {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<PublishingCompany> PublishingCompanies { get; set; }

        public BookManagerContext (DbContextOptions<BookManagerContext> options) : base (options) { }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Book> ()
                .HasOne(b => b.Genre);

            modelBuilder.Entity<Book> ()
                .HasOne (b => b.Author);

            modelBuilder.Entity<Book> ()
                .HasOne (b => b.PublishingCompany);

            modelBuilder.Entity<Author> ()
                .HasData (
                    new Author { Id = 1, Name = "Matheus" },
                    new Author { Id = 2, Name = "Marcos" },
                    new Author { Id = 3, Name = "Lucas" },
                    new Author { Id = 4, Name = "João" }
                );

            modelBuilder.Entity<PublishingCompany> ()
                .HasData (
                    new { Id = 1, Name = "Simon & Schuster	EUA" },
                    new { Id = 2, Name = "Egmont group	Dinamarca / Noruega " },
                    new { Id = 3, Name = "Woongjin ThinkBig	Coréia do Sul" },
                    new { Id = 4, Name = "RCS Libri	Itália	513	6063" }
                );

            modelBuilder.Entity<Genre> ()
                .HasData (
                    new { Id = 1, Description = "Épico" },
                    new { Id = 2, Description = "Fábula" },
                    new { Id = 3, Description = "Epopeia" },
                    new { Id = 4, Description = "Novela" }
                );

        }
    }
}



