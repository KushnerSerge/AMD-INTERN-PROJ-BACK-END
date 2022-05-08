using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class WorkoutNotFoundException : NotFoundException
    {
        public WorkoutNotFoundException(Guid workoutId) : base($"The workout with id: {workoutId} doesn't exist in the database.")
        {
        }
    }
}
