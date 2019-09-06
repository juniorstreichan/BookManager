using System.Linq;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Mock.Repository;
using Xunit;

namespace BookManager.UnitTests.Repository {
    public class AuthorRepositoryTests {
        private IAuthorRepository _repository = new AuthorRepository ();

        [Fact]
        public void Should_List_Authors () {

            var authors = _repository.FindAll ();

            Assert.Equal (authors.Count (), 4);
        }

        [Fact]
        public void Should_Add_An_Author () {
            var author = _repository.Insert (new Author { Id = 5, Name = "TESTE" });
            var authors = _repository.FindAll ();
            Assert.Equal (authors.Count (), 5);
            Assert.Equal (author.Name, "TESTE");
            Assert.NotNull (author);
        }

        [Fact]
        public void Should_Find_Authors_By_Expression () {

            var authors = _repository.Find (a => a.Name == "João");

            Assert.NotEmpty (authors);
            Assert.Equal (authors.First ().Name, "João");
        }

        [Fact]
        public void Should_Find_Authors_By_Id () {

            var author = _repository.ById (4);

            Assert.NotNull (author);
            Assert.Equal (author.Name, "João");
            Assert.Equal (author.Id, 4);
        }

        [Fact]
        public void Should_Update_An_Author () {
            _repository.Update (new Author { Id = 2, Name = "Paulo" });
            var author = _repository.ById (2);

            Assert.NotNull (author);
            Assert.Equal (author.Name, "Paulo");
        }

        [Fact]
        public void Should_Delete_An_Author () {
            _repository.Delete (2);
            var author = _repository.ById (2);

            Assert.Null (author);
            Assert.Equal (_repository.FindAll ().Count (), 3);
        }

    }
}