using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{

    public class MatchUpdate
    {
        [Required(ErrorMessage = "gelieve een update te geven")]
        public string UpdateMessage { get; set; }

        public DateTime Time { get; set; }

        public string FullUpdate
        {
            get
            {
                return $"{TimeOnly.FromDateTime(Time)}: {UpdateMessage}";
            }
        }
    }
}
