using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class WorkoutService : IWorkoutService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public WorkoutService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Workout>> GetWorkoutsAsync(string userId, bool trackChanges)
        {
            var workoutsFromDb = await _repository.Workout.GetWorkoutsAsync(userId, trackChanges);

            //  var workoutsDto = _mapper.Map<IEnumerable<WorkoutDto>>(workoutsFromDb);
            return workoutsFromDb;
        }

        public async Task<Workout> GetWorkoutAsync(string userId, Guid id, bool trackChanges)
        {
            var workoutDb = await _repository.Workout.GetWorkoutAsync(userId, id, trackChanges);
            if (workoutDb is null)
                throw new WorkoutNotFoundException(id);

            //  var workout = _mapper.Map<WorkoutDto>(workoutDb);
            return workoutDb;
        }


        public async Task<WorkoutDto> CreateWorkoutForUserAsync(string userId, WorkoutForCreationDto workoutForCreation, bool trackChanges)
        {
            var workoutEntity = _mapper.Map<Workout>(workoutForCreation);

            _repository.Workout.CreateWorkoutForUser(userId, workoutEntity);
            await _repository.SaveAsync();

              var workoutToReturn = _mapper.Map<WorkoutDto>(workoutEntity);

            return workoutToReturn;
        }


        public async Task UpdateWorkoutForUserAsync(string userId, Guid id, WorkoutForUpdateDto workoutForUpdate, bool trackChanges)
        {
            var workout = await GetWorkoutAndCheckIfItExists(userId, id, trackChanges);
            _mapper.Map(workoutForUpdate, workout);
            await _repository.SaveAsync();
        }

        public async Task DeleteWorkoutForUser(string userId, Guid id, bool trackChanges)
        {
            var workoutDb = await _repository.Workout.GetWorkoutAsync(userId, id, trackChanges);
            _repository.Workout.DeleteWorkout(workoutDb);
            await _repository.SaveAsync();
        }

        private async Task<Workout> GetWorkoutAndCheckIfItExists(string userId, Guid id, bool trackChanges)
        {
            var workout = await _repository.Workout.GetWorkoutAsync(userId, id, trackChanges);
            if (workout is null)
                throw new WorkoutNotFoundException(id);

            return workout;
        }

    }

}

