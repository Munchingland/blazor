using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class UpdateHistoryModel
    {
        public PointGain PointGain { get; set; }

        public Tournament TournamentToUpdateHistory { get; set; }

        public MatchUpdate MatchUpdate { get; set; }

        public Competitor Competitor { get; set; }
    }
}
