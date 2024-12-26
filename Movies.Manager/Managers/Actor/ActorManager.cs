using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.DataServices.Abstract;
using Movies.Manager.Models.DTOs;

namespace Movies.Manager.Managers.Actor
{
    public class ActorManager
    {
        private readonly IActorDataService _actorDataService;

        public ActorManager(IActorDataService actorDataService)
        {
            _actorDataService = actorDataService;
        }

        public async Task<List<ActorDTO>> GetActors()
        {
            var res = await _actorDataService.GetActors();

            return res.Select(x => ActorDTO.MapToDTO(x)).ToList();
        }

        public async Task<bool> AddActors(ActorDTO actorDTO)
        {

            var res = ActorDTO.MapToEntity(actorDTO);

            return await _actorDataService.AddActors(res);
        }

        public async Task<ActorDTO> UpdateActors(ActorDTO actorDTO, int ActId)
        {

            var user = ActorDTO.MapToEntity(actorDTO);
            user.ActId = ActId;

            var res = await _actorDataService.UpdateActors(user);

            return ActorDTO.MapToDTO(res);
        }


        public async Task<string> UpsertActor(ActorDTO actorDTO)
        {
            // Map DTO to entity
            var actorEntity = ActorDTO.MapToEntity(actorDTO);

            //if (actorEntity)
            //{
            //    // Assign ActId if provided
            //    actorEntity.ActId = ActId;
            //}

            var res = await _actorDataService.UpsertActor(actorEntity);
            return res;

        }

        public async Task<ActorDTO> GetActorById(int ActId)
        {
            var res = await _actorDataService.GetActorById(ActId);
            return ActorDTO.MapToDTO(res);
        }

        public async Task<bool> DeleteActorById(int ActId)
        {

            return await _actorDataService.DeleteActorById(ActId);
        }

    }
}
    