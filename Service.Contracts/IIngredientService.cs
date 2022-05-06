using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IIngredientService
    {
        Task<IEnumerable<IngredientDto>> GetAllIngredientsAsync(bool trackChanges);
        Task<IngredientDto> GetIngredientAsync(Guid userId, bool trackChanges);
        Task<IngredientDto> CreateIngredientAsync(IngredientForCreationDto company);

        Task DeleteIngredientAsync(Guid mealId, bool trackChanges);
    }
}
