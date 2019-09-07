using System.Collections.Generic;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.WebAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class AuthorsController : Controller {

        private readonly IAuthorService _service;

        public AuthorsController (IAuthorService service) {
            _service = service;
        }

        [HttpGet]
        [DisableCors]
        public ActionResult<IEnumerable<Author>> GetAll () {
            var authors = _service.GetAll ();

            return Ok (authors);
        }

    }
}