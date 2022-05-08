using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Workout
    {
        [Column("WorkoutId")]
        public Guid? WorkoutId { get; set; }

        [Required(ErrorMessage = "Workout  name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Name { get; set; }

        [MaxLength(60, ErrorMessage = "Maximum length for the Type is 60 characters.")]
        public string? Type { get; set; }

        public Strength? Strength { get; set; }
        public Endurance? Endurance { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }
               
    }
}
