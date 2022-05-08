using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
	
	public interface IMealService
	{
		Task<IEnumerable<Meal>> GetMealsAsync(string userId, bool trackChanges);
		Task<MealDto> GetMealAsync(string userId, Guid id, bool trackChanges);
		Task<Meal> GetMealAndIngredientsAsync(string userId, Guid id, bool trackChanges);
		Task<MealDto> CreateMealForUserAsync(string userId, MealForCreationDto mealForCreation, bool trackChanges);
		Task UpdateMealForUserAsync(string userId, Guid id, MealForUpdateDto mealForUpdate, bool trackChanges);
		Task DeleteMealForUser(string userId, Guid id, bool trackChanges);


	}
}
