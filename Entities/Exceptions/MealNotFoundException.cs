using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class MealNotFoundException : NotFoundException
    {
        public MealNotFoundException(Guid mealId)
        : base($"The meal with id: {mealId} doesn't exist in the database.")
        {
        }
    }
}
