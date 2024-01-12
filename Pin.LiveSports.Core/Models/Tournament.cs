using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Tournament
    {
        public List<Competitor> Competitors { get; set; }
        public List<MatchUpdate> MatchHistory { get; set; }
        public string NameCompetition { get; set; }

    }
}
