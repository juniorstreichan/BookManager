using System.Linq;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Mock.Repository;
using Xunit;

namespace BookManager.UnitTests.Repository {
    public class GenreRepositoryTests {
        private IGenreRepository _repository = new GenreRepository ();

        [Fact]
        public void Should_List_Genres () {

            var objs = _repository.FindAll ();

            Assert.Equal (objs.Count (), 4);
        }

        [Fact]
        public void Should_Add_An_Author () {
            var obj = _repository.Insert (new Genre { Id = 5, Description = "TESTE" });
            var objs = _repository.FindAll ();
            Assert.Equal (objs.Count (), 5);
            Assert.Equal (obj.Description, "TESTE");
            Assert.NotNull (obj);
        }

        [Fact]
        public void Should_Find_Genres_By_Expression () {

            var objs = _repository.Find (a => a.Description == "Épico");

            Assert.NotEmpty (objs);
            Assert.Equal (objs.First ().Description, "Épico");
        }

        [Fact]
        public void Should_Find_Genres_By_Id () {

            var obj = _repository.ById (4);

            Assert.NotNull (obj);
            Assert.Equal (obj.Description, "Novela");
            Assert.Equal (obj.Id, 4);
        }

        [Fact]
        public void Should_Update_An_Author () {
            _repository.Update (new Genre { Id = 2, Description = "Drama" });
            var obj = _repository.ById (2);

            Assert.NotNull (obj);
            Assert.Equal (obj.Description, "Drama");
        }

        [Fact]
        public void Should_Delete_An_Author () {
            _repository.Delete (2);
            var obj = _repository.ById (2);

            Assert.Null (obj);
            Assert.Equal (_repository.FindAll ().Count (), 3);
        }
    }
}