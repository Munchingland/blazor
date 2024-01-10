using Pin.LiveSports.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services.Interfaces
{
    public interface IMatchService
    {
        public List<MatchUpdate> GetMatchHistory();
        public void AddUpdateToHistory(MatchUpdate update);
    }
}
