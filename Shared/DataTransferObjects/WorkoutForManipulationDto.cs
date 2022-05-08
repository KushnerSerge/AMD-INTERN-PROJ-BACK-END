using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record  WorkoutForManipulationDto
    {

        [Required(ErrorMessage = "Workout  name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Name { get; set; }

        [MaxLength(60, ErrorMessage = "Maximum length for the Type is 60 characters.")]
        public string? Type { get; set; }
    }
}
