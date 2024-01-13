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

        public void UpdateTournament(Tournament tournament, List<WindSurfer> competitors, List<WindSurfer> notCompeting)
        {
            foreach(var competitor in competitors)
            {
                if (!tournament.Competitors.Select(c => c.Surfer.Id).Contains(competitor.Id))
                {
                    var comp = new Competitor
                    {
                        Id = tournament.Competitors.Select(c => c.Id).DefaultIfEmpty(1).Max(),
                        Surfer = competitor,
                    };
                    AddPhasesToCompetitor(comp);
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


        private void AddPhasesToCompetitor(Competitor comp)
        {
            comp.PointsGained = new List<PointGain>();
            List<string> phases= new List<string>() { Constants.Intro, Constants.Single, Constants.Combo, Constants.SwitchStance, Constants.Air, Constants.Power, Constants.Final };
            foreach (string phase in phases)
            {
                comp.PointsGained.Add(new PointGain
                {
                    Phase = phase,
                });
            }
        }
    }
}
