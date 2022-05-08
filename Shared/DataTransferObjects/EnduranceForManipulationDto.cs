using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record EnduranceForManipulationDto
    {
        [Required(ErrorMessage = "Endurance  distance is a required field.")]
        public int? Distance { get; set; }

        [Required(ErrorMessage = "Endurance  Duration is a required field.")]
        public int? Duration { get; set; }
    }
}
