﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public List<Competitor> Competitors { get; set; }
        public List<MatchUpdate>? MatchHistory { get; set; } = new List<MatchUpdate>();
        [Required(ErrorMessage ="Gelieve een naam in te geven")]
        public string Name { get; set; }
        public bool HasStarted { get; set; }
        public bool HasCompleted { get; set; }

    }
}
