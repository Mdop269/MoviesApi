using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Movies.DataServices.EntityData.EntityModels;

namespace Movies.Manager.Models.DTOs
{
    public class ActorDTO
    {

        public string? ActFname { get; set; }

        public string? ActLname { get; set; }

        public string? ActGender { get; set; }

        //MapToEntity: Converts a ActorDTO object to an Actor entity.
        public static Actor MapToEntity(ActorDTO actorDTO)
        {
            return new Actor
            {
                ActFname = actorDTO.ActFname,
                ActLname = actorDTO.ActLname,
                ActGender = actorDTO.ActGender, 
            };
        }

        //MapToDTO: Converts an Actor entity to an ActorDTO object.
        public static ActorDTO MapToDTO(Actor actor) => new ActorDTO
        {
 
            ActFname = actor.ActFname,
            ActLname = actor.ActLname,
            ActGender = actor.ActGender,

        };
    }
}
