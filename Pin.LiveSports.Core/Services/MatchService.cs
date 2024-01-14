using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services
{
    public class MatchService : IMatchService
    {
        private static List<MatchUpdate> matchHistory = new List<MatchUpdate>();
        public List<MatchUpdate> GetMatchHistory()
        {
            return matchHistory;
        }

        public void AddUpdateToHistory(UpdateHistoryModel update )
        { 
            update.MatchUpdate.Time = DateTime.Now;
            if(update.MatchUpdate.Phase == Constants.Start)
            {
                update.MatchUpdate.UpdateMessage = $"De start van {update.Competitor.Surfer.Name} routine";
            }
            else
            {
                foreach(var point in update.MatchUpdate.PointGain.GetType().GetProperties())
                {
                    var value = point.GetValue(update.MatchUpdate.PointGain);
                    if(point.PropertyType != typeof(double?))
                    {
                        if (value == null)
                        {
                            point.SetValue(update.MatchUpdate.PointGain, 1);
                        }
                    }
                    
                }

                var total = update.MatchUpdate.PointGain.DifficultyOfManuevers +
                        update.MatchUpdate.PointGain.StyleAndFluidity +
                        update.MatchUpdate.PointGain.VarietyOfTricks +
                        update.MatchUpdate.PointGain.HeightAndAirTime +
                        update.MatchUpdate.PointGain.InnovationAndCreativity;
                update.MatchUpdate.PointGain.TotalPoints = total;
                update.MatchUpdate.PointGain.AveragePoints = total / 5;
            }

            update.TournamentToUpdateHistory.HasStarted = true;
            update.TournamentToUpdateHistory.MatchHistory.Add(update.MatchUpdate);
            update.Competitor.PointsGained.Add(update.MatchUpdate.PointGain);
        }
    }
}
