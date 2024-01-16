using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

        public List<MatchUpdate> GetTournamentHistory(int tournamentId)
        {
            var tournament = GetById(tournamentId);
            return tournament.MatchHistory;
        }

        public void CreateTournament(List<WindSurfer> windSurfers, string name)
        {
            int id = _tournaments.Any() ? _tournaments.Max(t => t.Id + 1) : 1;
            List<Competitor> competitors = new List<Competitor>();
            var i = 0;
            foreach (var surfer in windSurfers)
            {
                var comp = new Competitor
                {
                    Id = competitors.Any() ? competitors.Max(c => c.Id+1) : 1,
                    Surfer = surfer,
                };
                comp.PointsGained = new List<PointGain>();
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

        public List<string> GetPhasesInTournament()
        {
            return new List<string>() { Constants.Intro, Constants.Single, Constants.Combo, Constants.SwitchStance, Constants.Air, Constants.Power, Constants.Final };
        }

        public void UpdateTournament(Tournament tournament, List<WindSurfer> competitors, List<WindSurfer> notCompeting)
        {
            foreach(var competitor in competitors)
            {
                if (!tournament.Competitors.Select(c => c.Surfer.Id).Contains(competitor.Id))
                {
                    var comp = new Competitor
                    {
                        Id = tournament.Competitors.Any() ? tournament.Competitors.Max(c => c.Id+1): 1,
                        Surfer = competitor,
                    };
                    tournament.Competitors.Add(comp);
                }
            }
            foreach(var competitor in notCompeting)
            {
                if (tournament.Competitors.Select(c => c.Surfer.Id).Contains(competitor.Id))
                {
                    var comp = tournament.Competitors.FirstOrDefault(s=>s.Surfer.Id == competitor.Id);
                    tournament.Competitors.Remove(comp);
                }
            }
            Tournament tournamentToUpdate = GetById(tournament.Id);
            tournamentToUpdate.Competitors = tournament.Competitors;
            tournamentToUpdate.HasStarted = tournament.HasStarted;
            tournamentToUpdate.MatchHistory = tournament.MatchHistory;
            tournamentToUpdate.HasCompleted = tournament.HasCompleted;
        }
    }
}
