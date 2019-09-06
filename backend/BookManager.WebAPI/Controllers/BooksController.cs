using System.Collections.Generic;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.WebAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class BooksController : Controller, CRUDController<Book> {
        private readonly IBookService _service;

        public BooksController (IBookService service) {
            _service = service;
        }

        [HttpDelete]
        public ActionResult Delete (int id) {
            _service.Remove(id);
            return Ok();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll () {
            var list = _service.GetAll ();
            return Ok (list);
        }

        [HttpGet ("{id}")]
        public ActionResult<Book> GetById (int id) {
            var obj = _service.GetById (id);
            return Ok (obj);
        }

        [HttpPost]
        public ActionResult<Book> Post ([FromBody] Book entity) {
            var newBook = _service.Add (entity);
            return Created ('/' + newBook.Id.ToString (), newBook);
        }

        [HttpPut]
        public ActionResult<Book> Put ([FromBody] Book entity) {
            var changedBook = _service.Change (entity);
            return Ok (changedBook);
        }
    }
}