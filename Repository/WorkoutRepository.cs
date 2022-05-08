using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class WorkoutRepository : RepositoryBase<Workout>, IWorkoutRepository
    {
        public WorkoutRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }


        public async Task<IEnumerable<Workout>> GetWorkoutsAsync(string userId, bool trackChanges) =>
        await FindByCondition(e => e.UserId.Equals(userId), trackChanges).Include(str=>str.Strength).Include(end => end.Endurance)
        .ToListAsync();


        public async Task<Workout> GetWorkoutAsync(string userId, Guid id, bool trackChanges) =>
       await FindByCondition(e => e.UserId.Equals(userId) && e.WorkoutId.Equals(id), trackChanges).Include(str => str.Strength).Include(end => end.Endurance)
       .SingleOrDefaultAsync();



        public void CreateWorkoutForUser(string userId, Workout workout)
        {

            workout.UserId = userId;
            Create(workout);
        }

        public void DeleteWorkout(Workout workout)
        => Delete(workout);



    }
}
