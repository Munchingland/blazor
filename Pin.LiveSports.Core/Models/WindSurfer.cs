using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class WindSurfer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Gelieve een naam in te geven")]
        public string Name { get; set; }
    }
}
