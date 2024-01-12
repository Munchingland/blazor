

namespace Pin.LiveSports.Core.Models
{
    public class Competitor
    {
        public int Id {  get; set; }
        public WindSurfer Surfer { get; set; }
        public PointGain? PointsGained { get; set; }
        public bool WonCompetition { get; set; }
    }
}