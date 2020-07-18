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
        
        [HttpGet("cityTasks")]
        public async Task<IEnumerable<CityTask>> GetCityTasks()
        {
            return await _service.LoadCityTasks();
        }
        
        [HttpGet("objectFeedbacks")]
        public async Task<IEnumerable<ObjectFeedback>> GetObjectFeedbacks()
        {
            return await _service.LoadFeedbacks();
        }
        
        [HttpGet("districts")]
        public async Task<IEnumerable<District>> GetDistricts()
        {
            return await _service.LoadDistricts();
        }
        
        
        [HttpGet("objectScores/{id}")]
        public async Task<IEnumerable<ObjectScore>> GetObjectScores(long id)
        {
            return await _service.LoadObjectScores(id);
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
        
        [HttpPost("task/create")]
        public async Task<IActionResult> CreateTask([FromBody] CityTask cityTask)
        {
            await _service.AddTask(cityTask);
            return Ok();
        }
        
        [HttpPost("task/update")]
        public async Task<IActionResult> UpdateTask([FromBody] CityTask cityTask)
        {
            await _service.UpdateTask(cityTask);
            return Ok();
        }
        
    }
}