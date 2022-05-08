using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;


namespace Service
{
    internal sealed class MealService : IMealService
    {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public MealService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }


        public async Task<IEnumerable<Meal>> GetMealsAsync(string userId, bool trackChanges)
        {
            var mealsFromDb = await _repository.Meal.GetMealsAsync(userId, trackChanges);

            // var mealsDto = _mapper.Map<IEnumerable<MealDto>>(mealsFromDb);
            return mealsFromDb;
        }

        public async Task<MealDto> GetMealAsync(string userId, Guid id, bool trackChanges)
        {
            var mealDb = await _repository.Meal.GetMealAsync(userId, id, trackChanges);
            if (mealDb is null)
                throw new MealNotFoundException(id);

            var meal = _mapper.Map<MealDto>(mealDb);
            return meal;
        }

        public async Task<Meal> GetMealAndIngredientsAsync(string userId, Guid id, bool trackChanges)
        {
            var mealDb = await _repository.Meal.GetMealAndIngredientsAsync(userId, id, trackChanges);
            if (mealDb is null)
                throw new MealNotFoundException(id);

            // var meal = _mapper.Map<MealDto>(mealDb);
            return mealDb;
        }



        public async Task<MealDto> CreateMealForUserAsync(string userId, MealForCreationDto mealForCreation, bool trackChanges)
        {
            var mealEntity = _mapper.Map<Meal>(mealForCreation);

            _repository.Meal.CreateMealForUser(userId, mealEntity);
            await _repository.SaveAsync();

            var mealToReturn = _mapper.Map<MealDto>(mealEntity);

            return mealToReturn;
        }

        public async Task DeleteMealForUser(string userId, Guid id, bool trackChanges)
        {
            var mealDb = await _repository.Meal.GetMealAsync(userId, id, trackChanges);
            Console.WriteLine(mealDb);
            _repository.Meal.DeleteMeal(mealDb);
            await _repository.SaveAsync();
        }

  

        public async Task UpdateMealForUserAsync(string userId, Guid id, MealForUpdateDto mealForUpdate, bool trackChanges)
        {
            var meal = await GetMealAndIngredientsAsync(userId,id, trackChanges);

            _mapper.Map(mealForUpdate, meal);
            await _repository.SaveAsync();
        }

    

    }
}
