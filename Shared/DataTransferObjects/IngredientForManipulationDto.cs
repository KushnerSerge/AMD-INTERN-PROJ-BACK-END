using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record IngredientForManipulationDto
    {

        [Required(ErrorMessage = "Ingredient  name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name Ingredient is 60 characters.")]
        public string? Name { get; set; }

    }
}
