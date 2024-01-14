

namespace Pin.LiveSports.Core.Models
{
    public class Competitor
    {
        public int Id {  get; set; }
        public WindSurfer Surfer { get; set; }
        public List<PointGain>? PointsGained { get; set; }
        public bool WonCompetition { get; set; }
        public bool FinishedRoutine { get; set; }

        public int? TotalPointsGained => PointsGained.Sum(p => p.TotalPoints);
    }
}