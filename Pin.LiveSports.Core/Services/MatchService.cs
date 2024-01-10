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

        public void AddUpdateToHistory(MatchUpdate update)
        {
            matchHistory.Add(update);
        }
    }
}
