using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services
{
    public class CompetitorService : ICompetitorService
    {
        private Random random = new Random();
        private static List<Competitor> _competitors;

        public CompetitorService()
        {
            _competitors = new List<Competitor>();
            CreateRandomCompetitors(10);

        }

        private void CreateRandomCompetitors(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Competitor competitor = new Competitor
                {
                    Name =$"Deelnemer{i}",
                    Id = i ,
                };
                _competitors.Add(competitor);
            }
        }


        public void AddCompetitor(Competitor competitor)
        {
            competitor.Id = _competitors.Max(c=>c.Id) + 1;
            _competitors.Add(competitor);
        }

        public List<Competitor> GetAll()
        {
            return _competitors;
        }
    }
}
