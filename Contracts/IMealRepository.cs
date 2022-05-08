using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMealRepository
    {
        Task<IEnumerable<Meal>> GetMealsAndIngredientsAsync(string userId, bool trackChanges);
        Task<IEnumerable<Meal>> GetMealsAsync(string userId, bool trackChanges);
        Task<Meal> GetMealAsync(string userId, Guid id, bool trackChanges);
        Task<Meal> GetMealAndIngredientsAsync(string userId, Guid id, bool trackChanges);    
        void CreateMealForUser(string userId, Meal meal);
        void DeleteMeal(Meal employee);
    }
}
