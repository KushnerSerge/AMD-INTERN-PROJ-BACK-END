using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Meal
    {
        [Column("MealId")]
        public Guid? MealId { get; set; }

        [Required(ErrorMessage = "Meal  name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Name { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }

        public ICollection<Ingredient>? Ingredients { get; set; }

    }
}
