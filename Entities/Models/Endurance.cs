using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Endurance
    {
        [Column("EnduranceId")]
        public Guid?  EnduranceId { get; set; }

        [Required(ErrorMessage = "Endurance  distance is a required field.")]
        public int? Distance { get; set; }

        [Required(ErrorMessage = "Endurance  Duration is a required field.")]
        public int? Duration { get; set; }
                     
        public Guid? WorkoutId { get; set; }
        public Workout? Workout { get; set; }
    }
}
