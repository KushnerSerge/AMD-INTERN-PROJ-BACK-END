using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record StrengthForManipulationDto
    {
        [Required(ErrorMessage = "Strength  reps is a required field.")]
        public int? reps { get; set; }

        [Required(ErrorMessage = "Strength  sets is a required field.")]
        public int? sets { get; set; }


        [Required(ErrorMessage = "Strength  weight is a required field.")]
        public int? weight { get; set; }
    }
}
