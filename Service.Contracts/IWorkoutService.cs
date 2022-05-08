using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IWorkoutService
    {
		Task<IEnumerable<Workout>> GetWorkoutsAsync(string userId, bool trackChanges);
		Task<Workout> GetWorkoutAsync(string userId, Guid id, bool trackChanges);
		
		Task<WorkoutDto> CreateWorkoutForUserAsync(string userId, WorkoutForCreationDto workoutForCreation, bool trackChanges);
		Task UpdateWorkoutForUserAsync(string userId, Guid id, WorkoutForUpdateDto workoutForUpdate, bool trackChanges);
		Task DeleteWorkoutForUser(string userId, Guid id, bool trackChanges);

	}
}
