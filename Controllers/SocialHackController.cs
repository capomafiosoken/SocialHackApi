using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialHackApi.Models;

namespace SocialHackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SocialHackController : ControllerBase
    {
        
        private readonly ILogger<SocialHackController> _logger;
        private readonly SocialHackService _service;
        public SocialHackController(ILogger<SocialHackController> logger, SocialHackService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("cityObjects")]
        public async Task<IEnumerable<CityObject>> GetCityObjects()
        {
            return await _service.LoadObjectsByWeight();
        }
        [HttpGet("cityTask")]
        public async Task<IEnumerable<CityTask>> Get()
        {
            return await _service.LoadObjectsByWeight();
        }

        [HttpPost("feedback/create")]
        public async Task<IActionResult> CreateFeedback([FromBody] ObjectFeedback objectFeedback)
        {
            await _service.AddFeedback(objectFeedback);
            return Ok();
        }
       
        [HttpPost("score/create")]
        public async Task<IActionResult> CreateScore([FromBody] ObjectScore objectScore)
        {
            await _service.AddScore(objectScore);
            return Ok();
        }
        [HttpPost("score/create")]
        public async Task<IActionResult> CreateTask([FromBody] CityTask cityTask)
        {
            await _service.AddTask(cityTask);
            return Ok();
        }
    }
}