using System;
using System.Linq;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Mock.Repository;
using Xunit;

namespace BookManager.UnitTests.Repository {
    public class BookRepositoryTests {
        private IBookRepository _repository = new BookRepository ();

        [Fact]
        public void Should_List_Books () {

            var objs = _repository.FindAll ();

            Assert.Equal (objs.Count (), 10);
        }

        [Fact]
        public void Should_Add_An_Book () {
            var obj = _repository.Insert (
                new Book {
                    Id = 11,
                        Title = "Reggie",
                        PublishDate = new DateTime (),
                        Pages = 500,
                        Description = "TESTE",
                        Synopsis = "Horizontal background model",
                        ImageUrl = "http://dummyimage.com/166x152.bmp/5fa2dd/ffffff",
                        BuyLink = "https://ucsd.edu/rhoncus.jpg?vestibulum=odio&ante=elementum&ipsum=eu&primis=interdum&in=eu&faucibus=tincidunt&orci=in&luctus=leo&et=maecenas&ultrices=pulvinar&posuere=lobortis&cubilia=est&curae=phasellus&duis=sit&faucibus=amet&accumsan=erat&odio=nulla&curabitur=tempus&convallis=vivamus&duis=in&consequat=felis&dui=eu&nec=sapien&nisi=cursus&volutpat=vestibulum&eleifend=proin&donec=eu&ut=mi&dolor=nulla&morbi=ac&vel=enim&lectus=in&in=tempor&quam=turpis&fringilla=nec&rhoncus=euismod&mauris=scelerisque&enim=quam&leo=turpis&rhoncus=adipiscing&sed=lorem&vestibulum=vitae&sit=mattis&amet=nibh&cursus=ligula&id=nec&turpis=sem&integer=duis&aliquet=aliquam&massa=convallis&id=nunc&lobortis=proin&convallis=at&tortor=turpis&risus=a",
                        AuthorId = 2,
                        PublishingCompanyId = 3,
                        GenreId = 4
                }
            );
            var objs = _repository.FindAll ();
            Assert.Equal (objs.Count (), 11);
            Assert.Equal (obj.Description, "TESTE");
            Assert.NotNull (obj);
        }

        [Fact]
        public void Should_Find_Books_By_Expression () {

            var objs = _repository.Find (a => a.Title == "Reggie");

            Assert.NotEmpty (objs);
            Assert.Equal (objs.First ().Title, "Reggie");
        }

        [Fact]
        public void Should_Find_Books_By_Author () {

            var objs = _repository.Find (a => a.AuthorId == 4);

            Assert.NotEmpty (objs);
        }

        [Fact]
        public void Should_Find_Books_By_Id () {

            var obj = _repository.ById (1);

            Assert.NotNull (obj);
            Assert.Equal (obj.Title, "Reggie");
            Assert.Equal (obj.Id, 1);
        }

        [Fact]
        public void Should_Update_An_Book () {
            var obj = _repository.ById (2);
            obj.Description = "LIVRO TOPZERA";
            obj = _repository.ById (2);

            Assert.NotNull (obj);
            Assert.Equal (obj.Description, "LIVRO TOPZERA");
        }

        [Fact]
        public void Should_Delete_An_Book () {
            _repository.Delete (2);
            var obj = _repository.ById (2);

            Assert.Null (obj);
            Assert.Equal (_repository.FindAll ().Count (), 9);
        }
    }
}