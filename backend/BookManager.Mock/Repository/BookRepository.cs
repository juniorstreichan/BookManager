using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;

namespace BookManager.Mock.Repository {
    public class BookRepository : IBookRepository {
        #region Data
        private List<Book> _data = new List<Book> {

            new Book {
            Id = 1,
            Title = "Reggie",
            PublishDate = new DateTime (),
            Pages = 500,
            Description = "Devolved eco-centric leverage",
            Synopsis = "Horizontal background model",
            ImageUrl = "http://dummyimage.com/166x152.bmp/5fa2dd/ffffff",
            BuyLink = "https://ucsd.edu/rhoncus.jpg?vestibulum=odio&ante=elementum&ipsum=eu&primis=interdum&in=eu&faucibus=tincidunt&orci=in&luctus=leo&et=maecenas&ultrices=pulvinar&posuere=lobortis&cubilia=est&curae=phasellus&duis=sit&faucibus=amet&accumsan=erat&odio=nulla&curabitur=tempus&convallis=vivamus&duis=in&consequat=felis&dui=eu&nec=sapien&nisi=cursus&volutpat=vestibulum&eleifend=proin&donec=eu&ut=mi&dolor=nulla&morbi=ac&vel=enim&lectus=in&in=tempor&quam=turpis&fringilla=nec&rhoncus=euismod&mauris=scelerisque&enim=quam&leo=turpis&rhoncus=adipiscing&sed=lorem&vestibulum=vitae&sit=mattis&amet=nibh&cursus=ligula&id=nec&turpis=sem&integer=duis&aliquet=aliquam&massa=convallis&id=nunc&lobortis=proin&convallis=at&tortor=turpis&risus=a",
            AuthorId = 2,
            PublishingCompanyId = 3,
            GenreId = 4
            },
            new Book {
            Id = 2,
            Title = "Maje",
            PublishDate = new DateTime (),
            Pages = 388,
            Description = "Reactive grid-enabled local area network",
            Synopsis = "Programmable leading edge firmware",
            ImageUrl = "http://dummyimage.com/104x203.png/dddddd/000000",
            BuyLink = "https://fastcompany.com/nibh.jpg?luctus=lorem&et=id&ultrices=ligula&posuere=suspendisse&cubilia=ornare&curae=consequat&donec=lectus&pharetra=in&magna=est&vestibulum=risus&aliquet=auctor&ultrices=sed&erat=tristique&tortor=in&sollicitudin=tempus&mi=sit&sit=amet&amet=sem&lobortis=fusce&sapien=consequat&sapien=nulla&non=nisl&mi=nunc&integer=nisl&ac=duis&neque=bibendum&duis=felis&bibendum=sed&morbi=interdum&non=venenatis&quam=turpis&nec=enim&dui=blandit&luctus=mi&rutrum=in&nulla=porttitor&tellus=pede&in=justo&sagittis=eu&dui=massa&vel=donec&nisl=dapibus&duis=duis&ac=at&nibh=velit&fusce=eu&lacus=est&purus=congue&aliquet=elementum&at=in&feugiat=hac&non=habitasse&pretium=platea&quis=dictumst&lectus=morbi&suspendisse=vestibulum",
            AuthorId = 2,
            PublishingCompanyId = 3,
            GenreId = 2
            },
            new Book {
            Id = 3,
            Title = "Tommie",
            PublishDate = new DateTime (),
            Pages = 202,
            Description = "Multi-layered demand-driven firmware",
            Synopsis = "Pre-emptive full-range paradigm",
            ImageUrl = "http://dummyimage.com/150x223.jpg/ff4444/ffffff",
            BuyLink = "http://hugedomains.com/morbi/odio/odio.png?ac=et&est=ultrices&lacinia=posuere&nisi=cubilia&venenatis=curae&tristique=mauris&fusce=viverra&congue=diam&diam=vitae&id=quam&ornare=suspendisse&imperdiet=potenti&sapien=nullam&urna=porttitor&pretium=lacus&nisl=at&ut=turpis&volutpat=donec&sapien=posuere&arcu=metus&sed=vitae&augue=ipsum&aliquam=aliquam&erat=non&volutpat=mauris&in=morbi&congue=non&etiam=lectus&justo=aliquam&etiam=sit&pretium=amet&iaculis=diam&justo=in&in=magna&hac=bibendum&habitasse=imperdiet&platea=nullam&dictumst=orci&etiam=pede&faucibus=venenatis&cursus=non&urna=sodales&ut=sed&tellus=tincidunt&nulla=eu&ut=felis&erat=fusce&id=posuere",
            AuthorId = 3,
            PublishingCompanyId = 4,
            GenreId = 4
            },
            new Book {
            Id = 4,
            Title = "Bree",
            PublishDate = new DateTime (),
            Pages = 478,
            Description = "Team-oriented mobile emulation",
            Synopsis = "Multi-tiered static challenge",
            ImageUrl = "http://dummyimage.com/196x156.png/5fa2dd/ffffff",
            BuyLink = "http://constantcontact.com/sed/interdum/venenatis/turpis/enim.js?sociis=amet&natoque=nunc&penatibus=viverra&et=dapibus&magnis=nulla&dis=suscipit&parturient=ligula&montes=in&nascetur=lacus&ridiculus=curabitur&mus=at&etiam=ipsum&vel=ac&augue=tellus&vestibulum=semper&rutrum=interdum&rutrum=mauris&neque=ullamcorper&aenean=purus&auctor=sit&gravida=amet&sem=nulla&praesent=quisque&id=arcu&massa=libero&id=rutrum&nisl=ac&venenatis=lobortis&lacinia=vel&aenean=dapibus&sit=at",
            AuthorId = 3,
            PublishingCompanyId = 3,
            GenreId = 1
            },
            new Book {
            Id = 5,
            Title = "Gavin",
            PublishDate = new DateTime (),
            Pages = 358,
            Description = "Streamlined foreground encoding",
            Synopsis = "Phased bottom-line open architecture",
            ImageUrl = "http://dummyimage.com/239x158.png/5fa2dd/ffffff",
            BuyLink = "http://ihg.com/nulla/mollis/molestie.jsp?interdum=dapibus&in=dolor&ante=vel&vestibulum=est&ante=donec&ipsum=odio&primis=justo&in=sollicitudin&faucibus=ut&orci=suscipit&luctus=a&et=feugiat&ultrices=et&posuere=eros&cubilia=vestibulum&curae=ac&duis=est&faucibus=lacinia&accumsan=nisi&odio=venenatis&curabitur=tristique&convallis=fusce&duis=congue&consequat=diam&dui=id&nec=ornare&nisi=imperdiet&volutpat=sapien&eleifend=urna&donec=pretium&ut=nisl&dolor=ut&morbi=volutpat&vel=sapien&lectus=arcu&in=sed&quam=augue&fringilla=aliquam&rhoncus=erat&mauris=volutpat&enim=in&leo=congue&rhoncus=etiam&sed=justo&vestibulum=etiam&sit=pretium&amet=iaculis&cursus=justo&id=in&turpis=hac&integer=habitasse&aliquet=platea&massa=dictumst&id=etiam&lobortis=faucibus&convallis=cursus&tortor=urna&risus=ut&dapibus=tellus&augue=nulla&vel=ut&accumsan=erat&tellus=id&nisi=mauris&eu=vulputate&orci=elementum&mauris=nullam&lacinia=varius&sapien=nulla&quis=facilisi&libero=cras&nullam=non&sit=velit&amet=nec&turpis=nisi&elementum=vulputate&ligula=nonummy&vehicula=maecenas&consequat=tincidunt&morbi=lacus&a=at&ipsum=velit&integer=vivamus&a=vel&nibh=nulla&in=eget&quis=eros&justo=elementum&maecenas=pellentesque&rhoncus=quisque",
            AuthorId = 3,
            PublishingCompanyId = 1,
            GenreId = 2
            },
            new Book {
            Id = 6,
            Title = "Carmita",
            PublishDate = new DateTime (),
            Pages = 479,
            Description = "Phased dedicated intranet",
            Synopsis = "Self-enabling hybrid portal",
            ImageUrl = "http://dummyimage.com/101x139.bmp/ff4444/ffffff",
            BuyLink = "https://japanpost.jp/quisque/erat/eros/viverra/eget/congue/eget.png?pellentesque=accumsan&viverra=odio&pede=curabitur&ac=convallis&diam=duis&cras=consequat&pellentesque=dui&volutpat=nec&dui=nisi&maecenas=volutpat&tristique=eleifend&est=donec&et=ut&tempus=dolor&semper=morbi&est=vel&quam=lectus&pharetra=in&magna=quam&ac=fringilla&consequat=rhoncus&metus=mauris&sapien=enim&ut=leo&nunc=rhoncus&vestibulum=sed&ante=vestibulum&ipsum=sit&primis=amet&in=cursus&faucibus=id&orci=turpis&luctus=integer&et=aliquet&ultrices=massa&posuere=id&cubilia=lobortis&curae=convallis&mauris=tortor&viverra=risus&diam=dapibus&vitae=augue&quam=vel&suspendisse=accumsan&potenti=tellus&nullam=nisi&porttitor=eu&lacus=orci&at=mauris&turpis=lacinia&donec=sapien&posuere=quis&metus=libero&vitae=nullam&ipsum=sit&aliquam=amet&non=turpis&mauris=elementum",
            AuthorId = 2,
            PublishingCompanyId = 1,
            GenreId = 2
            },
            new Book {
            Id = 7,
            Title = "Cosetta",
            PublishDate = new DateTime (),
            Pages = 213,
            Description = "Self-enabling client-driven policy",
            Synopsis = "Managed foreground internet solution",
            ImageUrl = "http://dummyimage.com/168x127.bmp/5fa2dd/ffffff",
            BuyLink = "http://ycombinator.com/nunc/viverra/dapibus/nulla.png?volutpat=risus&dui=praesent&maecenas=lectus&tristique=vestibulum&est=quam&et=sapien&tempus=varius&semper=ut&est=blandit&quam=non&pharetra=interdum&magna=in&ac=ante&consequat=vestibulum&metus=ante&sapien=ipsum&ut=primis&nunc=in&vestibulum=faucibus&ante=orci&ipsum=luctus&primis=et&in=ultrices&faucibus=posuere&orci=cubilia&luctus=curae&et=duis&ultrices=faucibus&posuere=accumsan&cubilia=odio&curae=curabitur&mauris=convallis&viverra=duis&diam=consequat&vitae=dui&quam=nec&suspendisse=nisi&potenti=volutpat&nullam=eleifend&porttitor=donec&lacus=ut&at=dolor&turpis=morbi&donec=vel&posuere=lectus&metus=in&vitae=quam&ipsum=fringilla&aliquam=rhoncus&non=mauris&mauris=enim&morbi=leo&non=rhoncus&lectus=sed&aliquam=vestibulum&sit=sit&amet=amet&diam=cursus&in=id&magna=turpis&bibendum=integer&imperdiet=aliquet&nullam=massa&orci=id&pede=lobortis&venenatis=convallis&non=tortor&sodales=risus&sed=dapibus&tincidunt=augue&eu=vel&felis=accumsan&fusce=tellus&posuere=nisi&felis=eu&sed=orci&lacus=mauris&morbi=lacinia&sem=sapien&mauris=quis&laoreet=libero&ut=nullam&rhoncus=sit&aliquet=amet&pulvinar=turpis&sed=elementum&nisl=ligula&nunc=vehicula&rhoncus=consequat&dui=morbi&vel=a&sem=ipsum&sed=integer&sagittis=a",
            AuthorId = 4,
            PublishingCompanyId = 2,
            GenreId = 2
            },
            new Book {
            Id = 8,
            Title = "Bertie",
            PublishDate = new DateTime (),
            Pages = 200,
            Description = "Synergized executive parallelism",
            Synopsis = "Total tertiary infrastructure",
            ImageUrl = "http://dummyimage.com/157x223.jpg/5fa2dd/ffffff",
            BuyLink = "http://ifeng.com/lacus/at/turpis.png?at=natoque&vulputate=penatibus&vitae=et&nisl=magnis&aenean=dis&lectus=parturient&pellentesque=montes&eget=nascetur&nunc=ridiculus&donec=mus&quis=etiam&orci=vel&eget=augue&orci=vestibulum&vehicula=rutrum&condimentum=rutrum&curabitur=neque&in=aenean&libero=auctor&ut=gravida&massa=sem&volutpat=praesent&convallis=id&morbi=massa&odio=id&odio=nisl&elementum=venenatis&eu=lacinia&interdum=aenean&eu=sit&tincidunt=amet&in=justo&leo=morbi&maecenas=ut&pulvinar=odio&lobortis=cras&est=mi&phasellus=pede&sit=malesuada&amet=in&erat=imperdiet&nulla=et&tempus=commodo&vivamus=vulputate&in=justo&felis=in&eu=blandit&sapien=ultrices&cursus=enim",
            AuthorId = 2,
            PublishingCompanyId = 3,
            GenreId = 2
            },
            new Book {
            Id = 9,
            Title = "Hubert",
            PublishDate = new DateTime (),
            Pages = 139,
            Description = "Open-source static framework",
            Synopsis = "Programmable zero tolerance task-force",
            ImageUrl = "http://dummyimage.com/164x226.png/5fa2dd/ffffff",
            BuyLink = "http://yellowbook.com/in/libero/ut/massa/volutpat/convallis/morbi.aspx?in=vel&sagittis=augue&dui=vestibulum&vel=rutrum&nisl=rutrum&duis=neque&ac=aenean&nibh=auctor&fusce=gravida&lacus=sem&purus=praesent&aliquet=id",
            AuthorId = 1,
            PublishingCompanyId = 3,
            GenreId = 1
            },
            new Book {
            Id = 10,
            Title = "Andie",
            PublishDate = new DateTime (),
            Pages = 249,
            Description = "Synergistic attitude-oriented moderator",
            Synopsis = "Horizontal incremental support",
            ImageUrl = "http://dummyimage.com/138x175.png/5fa2dd/ffffff",
            BuyLink = "https://shop-pro.jp/amet/erat/nulla/tempus/vivamus/in/felis.html?sit=integer&amet=a&sapien=nibh&dignissim=in&vestibulum=quis&vestibulum=justo&ante=maecenas&ipsum=rhoncus&primis=aliquam&in=lacus&faucibus=morbi&orci=quis&luctus=tortor&et=id&ultrices=nulla&posuere=ultrices&cubilia=aliquet&curae=maecenas&nulla=leo&dapibus=odio&dolor=condimentum&vel=id&est=luctus&donec=nec&odio=molestie&justo=sed&sollicitudin=justo&ut=pellentesque&suscipit=viverra&a=pede&feugiat=ac&et=diam&eros=cras&vestibulum=pellentesque&ac=volutpat&est=dui&lacinia=maecenas&nisi=tristique&venenatis=est&tristique=et&fusce=tempus&congue=semper&diam=est&id=quam&ornare=pharetra&imperdiet=magna&sapien=ac&urna=consequat&pretium=metus&nisl=sapien&ut=ut&volutpat=nunc&sapien=vestibulum&arcu=ante&sed=ipsum&augue=primis&aliquam=in&erat=faucibus&volutpat=orci&in=luctus&congue=et&etiam=ultrices&justo=posuere&etiam=cubilia&pretium=curae&iaculis=mauris&justo=viverra&in=diam&hac=vitae&habitasse=quam&platea=suspendisse&dictumst=potenti&etiam=nullam&faucibus=porttitor&cursus=lacus&urna=at&ut=turpis&tellus=donec&nulla=posuere&ut=metus&erat=vitae&id=ipsum",
            AuthorId = 2,
            PublishingCompanyId = 3,
            GenreId = 2
            }
        };
        #endregion

        public Book ById (int id) {
            try {
                return _data.First (a => a.Id == id);
            } catch (System.Exception) {
                return null;
            }
        }

        public void Delete (int id) {
            var obj = ById (id);

            if (obj != null) {
                _data.Remove (obj);
            }
        }

        public IQueryable<Book> Find (Expression<Func<Book, bool>> expression) {
            return _data.AsQueryable ().Where (expression);
        }

        public IEnumerable<Book> FindAll () {
            return _data;
        }

        public Book Insert (Book entity) {
            _data.Add (entity);
            return entity;
        }

        public Book Update (Book entity) {
            var obj = ById (entity.Id);

            if (obj != null) {
                _data.Remove (obj);
                _data.Add (entity);
            }

            return ById (entity.Id);
        }
    }
}