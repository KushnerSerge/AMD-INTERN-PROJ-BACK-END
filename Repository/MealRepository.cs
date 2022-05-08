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
    internal sealed class MealRepository : RepositoryBase<Meal>, IMealRepository
    {
        public MealRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Meal>> GetMealsAndIngredientsAsync(string userId, bool trackChanges) =>
       await FindAll(trackChanges).Include(ing => ing.Ingredients).ToListAsync();

        public async Task<IEnumerable<Meal>> GetMealsAsync(string userId, bool trackChanges) =>
        await FindByCondition(e => e.UserId.Equals(userId), trackChanges).Include(ing => ing.Ingredients).ToListAsync();


        public async Task<Meal> GetMealAsync(string userId, Guid id, bool trackChanges) =>
       await FindByCondition(e => e.UserId.Equals(userId) && e.MealId.Equals(id), trackChanges)
       .SingleOrDefaultAsync();

        public async Task<Meal> GetMealAndIngredientsAsync(string userId, Guid id, bool trackChanges) =>
      await FindByCondition(e => e.UserId.Equals(userId) && e.MealId.Equals(id), trackChanges).Include(ing => ing.Ingredients)
      .SingleOrDefaultAsync();


        public void CreateMealForUser(string userId, Meal meal)
        {

            meal.UserId = userId;
            Create(meal);
        }

        public void DeleteMeal(Meal meal)
        => Delete(meal);


    }
}
