using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class IngredientRepository : RepositoryBase<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public Task<IEnumerable<Ingredient>> GetAllIngredientsAsync(Guid mealId, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Ingredient> GetIngredientAsync(Guid mealId, Guid id, bool trackChanges)
        {
            throw new NotImplementedException();
        }


        public void CreateIngredient(Ingredient ingredient) => Create(ingredient);

        public void CreateIngredientForMeal(Guid mealId, Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(Ingredient ingredient) => Delete(ingredient);


    }
}
