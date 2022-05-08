using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record MealForUpdateDto : MealForManipulationDto
    {
        public IEnumerable<IngredientForCreationDto>? Ingredients { get; init; }
    }
}
