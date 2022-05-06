using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Ingredient
    {
        [Column("IngredientId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Ingredient  name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name Ingredient is 60 characters.")]
        public string? Name { get; set; }

        public Guid MealId { get; set; }
        public Meal? Meal { get; set; }

    }
}
