using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.DataServices.Abstract;
using Movies.DataServices.EntityData;
using Movies.DataServices.EntityData.EntityModels;

namespace Movies.DataServices.Services
{
    public class ActorDataService : IActorDataService
    {
        private FilmStudioContext _context;

        public ActorDataService(FilmStudioContext context)
        {
            _context = context;
        }

        // 
        public async Task<List<Actor>>  GetActors()
        {
            return await _context.Actors.ToListAsync(); 
        }

        public async Task<bool> AddActors(Actor actor)
        {
            await _context.AddAsync<Actor>(actor);
            _context.SaveChanges();
            return true;
        }

        public async Task<Actor> GetActorById(int ActId)
        {
            var actor = await _context.Actors
                .FindAsync(ActId);

            return (actor);
        }

        public async Task<Actor> UpdateActors(Actor actor)
        {
            var existingActor = await _context.Actors.FindAsync(actor.ActId);

            existingActor.ActFname = actor.ActFname;
            existingActor.ActLname = actor.ActLname;
            existingActor.ActGender = actor.ActGender;

            await _context.SaveChangesAsync();
            return actor;
        }

        //public async Task<Actor> UpdateActors(Actor actor)
        //{
        //    var existingActor = await _context.Actors.FindAsync(actor.ActId);
        //    if (existingActor != null)
        //    {
                    // Detached The Previously Track Entity
        //        _context.Entry(existingActor).State = EntityState.Detached;
        //    }
                // Attach the new instance and mark it as a modified
        //    _context.Entry(actor).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //    return actor;
        //}

        public async Task<bool> DeleteActorById(int ActId)
        {
            var existingActor = await _context.Actors.FindAsync(ActId);

            _context.Actors.Remove(existingActor);
            await _context.SaveChangesAsync();
            return true;

        }

    }
}
