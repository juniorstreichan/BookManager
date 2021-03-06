using System.Collections.Generic;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.WebAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class BooksController : Controller, CRUDController<Book> {
        private readonly IBookService _service;

        public BooksController (IBookService service) {
            _service = service;
        }

        [HttpDelete ("{id}")]
        [DisableCors]
        public ActionResult Delete (int id) {
            _service.Remove (id);
            return Ok ();
        }

        [HttpGet]
        [DisableCors]
        public ActionResult<IEnumerable<Book>> GetAll () {
            var list = _service.GetAll ();
            return Ok (list);
        }

        [HttpGet ("q")]
        [DisableCors]
        public ActionResult<IEnumerable<Book>> Search (
            [FromQuery] string title = "", [FromQuery] int author = 0
        ) {
            var list = _service.Search (
                title,
                author
            );
            return Ok (list);
        }

        [HttpGet ("{id}")]
        [DisableCors]
        public ActionResult<Book> GetById (int id) {
            var obj = _service.GetById (id);
            return Ok (obj);
        }

        [HttpPost]
        [DisableCors]
        public ActionResult<Book> Post ([FromBody] Book entity) {
            var newBook = _service.Add (entity);
            return Created ('/' + newBook.Id.ToString (), newBook);
        }

        [HttpPut]
        [DisableCors]
        public ActionResult<Book> Put ([FromBody] Book entity) {
            var changedBook = _service.Change (entity);
            return Ok (changedBook);
        }
    }
}