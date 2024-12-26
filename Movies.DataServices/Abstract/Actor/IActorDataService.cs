using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.DataServices.EntityData.EntityModels;

namespace Movies.DataServices.Abstract
{
    public interface IActorDataService
    {
        Task<List<Actor>> GetActors();

        Task<bool> AddActors(Actor actor);

        Task<Actor> GetActorById(int Actid);


        Task<Actor> UpdateActors(Actor actor);

        Task<String> UpsertActor(Actor actor);

        Task<bool> DeleteActorById(int ActId);


    }
}
