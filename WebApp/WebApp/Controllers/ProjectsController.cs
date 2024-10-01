using Entities.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;

        public ProjectsController(ILogger<ProjectsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var projects = new List<Projects>()
            {
                new Projects {Id=1, Title="ilk proje", Description="hello" }
            };
            _logger.LogInformation("The projects has been called.");
            return Ok(projects);
        }
    }
}
