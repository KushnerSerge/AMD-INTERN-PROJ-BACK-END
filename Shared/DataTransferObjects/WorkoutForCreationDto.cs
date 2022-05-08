using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record WorkoutForCreationDto : WorkoutForManipulationDto
    {
        public StrengthForCreationDto? Strength { get; init; }
        public EnduranceForCreationDto? Endurance { get; init; }

    }
}
