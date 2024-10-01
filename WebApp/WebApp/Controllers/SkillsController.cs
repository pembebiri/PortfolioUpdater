using Entities.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ILogger<SkillsController> _logger;

        public SkillsController(ILogger<SkillsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get() {

            var skills = new List<Skills>()
            {
                new Skills {Id=1,Name="programming"}
            };
            _logger.LogInformation("The controller has been called");
            return Ok(skills);
        
        }
    }
}
