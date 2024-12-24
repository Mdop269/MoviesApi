using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Manager.Managers.Actor;
using Movies.Manager.Models.DTOs;

namespace Movies.WebClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly ActorManager _actorManager;

        public ActorController(ActorManager actorManager)
        {
            _actorManager = actorManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<ActorDTO>>> GetActors()
        {
            var res = await _actorManager.GetActors();
            return res;
        }

        [HttpPost]
        public async Task<bool> addActors(ActorDTO actorDTO)
        {
            try
            {
                var res = await _actorManager.AddActors(actorDTO);
                return res;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpGet("{ActId}")]
        public async Task<ActionResult<ActorDTO>> GetActorById(int ActId)
        {
            var res = await _actorManager.GetActorById(ActId);
            if (res == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(res);
        }

        [HttpPut("{ActId}")]
        public async Task<ActionResult<ActorDTO>> UpdateActors(int ActId, ActorDTO actorDTO)
        {
            var res = await _actorManager.UpdateActors(actorDTO, ActId);
            if (res == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(res);
        }

        [HttpDelete]
        public async Task<bool> DeleteActorById(int ActId)
        {
            try
            {
                var res = await _actorManager.DeleteActorById(ActId);
                return res;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
