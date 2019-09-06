using BookManager.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.WebAPI.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class PublishersController : Controller {

        private readonly IPublishingCompanyService _service;

        public PublishersController (IPublishingCompanyService service) {
            _service = service;
        }
    }
}