using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class PointGain
    {
        [Required]
        public int? StyleAndFluidity { get; set; }
        [Required]
        public int? VarietyOfTricks { get; set; }
        [Required]
        public int? DifficultyOfManuevers { get; set; }
        [Required]
        public int? HeightAndAirTime { get; set; }
        [Required]
        public int? InnovationAndCreativity { get; set; }
        public string Phase { get; set; }
        public int? TotalPoints { get; set; }
        public double? AveragePoints { get; set; }
    }
}
