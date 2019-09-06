using System.Collections.Generic;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.WebAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class GenresController : Controller {
        private readonly IGenreService _service;

        public GenresController (IGenreService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Genre>> GetAll () {
            var authors = _service.GetAll ();

            return Ok (authors);
        }
    }
}