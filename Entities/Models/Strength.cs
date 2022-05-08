using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Strength
    {
        [Column("StrengthId")]
        public Guid? StrengthId { get; set; }

        [Required(ErrorMessage = "Strength  reps is a required field.")]
        public int? reps { get; set; }

        [Required(ErrorMessage = "Strength  sets is a required field.")]
        public int? sets { get; set; }


        [Required(ErrorMessage = "Strength  weight is a required field.")]
        public int? weight { get; set; }


        public Guid? WorkoutId { get; set; }
        public Workout? Workout { get; set; }
    }
}
