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


        public void CreateTournament(List<WindSurfer> windSurfers, string name)
        {
            int id = _tournaments.Select(a => a.Id).DefaultIfEmpty(1).Max();
            List<Competitor> competitors = new List<Competitor>();
            var i = 0;
            foreach (var surfer in windSurfers)
            {
                var comp = new Competitor
                {
                    Id = competitors.Select(c => c.Id).DefaultIfEmpty(1).Max(),
                    Surfer = surfer,
                };
                competitors.Add(comp);
            }

            Tournament toAdd = new Tournament
            {
                Competitors = competitors,
                Name = name,
                Id = id
            };
            _tournaments.Add(toAdd);
        }

        public List<Tournament> GetAll()
        {
            return _tournaments;
        }

        public Tournament GetById(int id)
        {
            return _tournaments.FirstOrDefault(t => t.Id == id);
        }
    }
}
