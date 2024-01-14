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
        public PointGain PointGain { get; set; } = new();
        public string SurferName { get; set; }
        public string Phase { get; set; }
        public DateTime Time { get; set; }

        public string FullUpdate
        {
            get
            {
                if(PointGain.TotalPoints!= null)
                {
                    return $"{UpdateMessage} en kreeg een totaal van {PointGain.TotalPoints} punten die omgezet worden naar {PointGain.AveragePoints} voor deze fase";
                }
                return $"{UpdateMessage}";
            }
        }
    }
}
