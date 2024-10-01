using Entities.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var projects = new List<Users>()
            {
                new Users {Id=1, name="ilk proje", password="hello" }
            };
            _logger.LogInformation("The users has been called.");
            return Ok(projects);
        }
    }
}
