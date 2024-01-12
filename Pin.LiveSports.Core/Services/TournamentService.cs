using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services
{
    public class TournamentService : ITournamentService
    {
        private static List<Tournament> _tournaments;
        public TournamentService()
        {
            _tournaments = new List<Tournament>();
        }


        public void CreateTournament(List<Competitor> competitors, string name)
        {
            int id = _tournaments.Select(a => a.Id).DefaultIfEmpty(0).Max();
            foreach (var competitor in competitors)
            {

            }
            Tournament toAdd = new Tournament
            {
                Competitors = competitors,
                Name = name,
                Id = id
            };
        }

        public List<Tournament> GetAll()
        {
            return _tournaments;
        }
    }
}
