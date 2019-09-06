using System.Linq;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Mock.Repository;
using Xunit;

namespace BookManager.UnitTests.Repository {
    public class PublishingCompanyRepositoryTests {
        private IPublishingCompanyRepository _repository = new PublishingCompanyRepository ();

        [Fact]
        public void Should_List_PublishingCompanies () {

            var objs = _repository.FindAll ();

            Assert.Equal (objs.Count (), 4);
        }

        [Fact]
        public void Should_Add_An_Author () {
            var author = _repository.Insert (new PublishingCompany { Id = 5, Name = "TESTE" });
            var authors = _repository.FindAll ();
            Assert.Equal (authors.Count (), 5);
            Assert.Equal (author.Name, "TESTE");
            Assert.NotNull (author);
        }

        [Fact]
        public void Should_Find_PublishingCompanies_By_Expression () {

            var authors = _repository.Find (a => a.Name == "RCS Libri	Itália	513	6063");

            Assert.NotEmpty (authors);
            Assert.Equal (authors.First ().Name, "RCS Libri	Itália	513	6063");
        }

        [Fact]
        public void Should_Find_PublishingCompanies_By_Id () {

            var author = _repository.ById (4);

            Assert.NotNull (author);
            Assert.Equal (author.Name, "RCS Libri	Itália	513	6063");
            Assert.Equal (author.Id, 4);
        }

        [Fact]
        public void Should_Update_An_Author () {
            _repository.Update (new PublishingCompany { Id = 2, Name = "SARAIVA" });
            var author = _repository.ById (2);

            Assert.NotNull (author);
            Assert.Equal (author.Name, "SARAIVA");
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