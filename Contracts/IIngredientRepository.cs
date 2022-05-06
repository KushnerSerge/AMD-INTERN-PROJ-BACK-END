using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IIngredientRepository
    {
        Task<IEnumerable<Ingredient>> GetAllIngredientsAsync(Guid mealId, bool trackChanges);
        Task<Ingredient> GetIngredientAsync(Guid mealId, Guid id, bool trackChanges);
        void CreateIngredientForMeal(Guid mealId, Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
    }
}
