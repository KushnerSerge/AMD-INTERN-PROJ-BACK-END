using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IWorkoutRepository
    {
        Task<IEnumerable<Workout>> GetWorkoutsAsync(string userId, bool trackChanges);
        Task<Workout> GetWorkoutAsync(string userId, Guid id, bool trackChanges);
        void CreateWorkoutForUser(string userId, Workout workout);
        void DeleteWorkout(Workout workout);
    }
}
