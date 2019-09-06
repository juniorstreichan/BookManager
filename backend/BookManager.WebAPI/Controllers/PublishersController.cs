using System.Collections.Generic;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.WebAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class PublishersController : Controller {

        private readonly IPublishingCompanyService _service;

        public PublishersController (IPublishingCompanyService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PublishingCompany>> GetAll(){
            var list = _service.GetAll();
            return Ok(list);
        }
    }
}