using Microsoft.AspNetCore.SignalR;
using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class MatchHub : Hub
    {
        private IMatchService _matchService;
        public MatchHub(IMatchService matchService)
        {
           _matchService = matchService;
        }

        public async Task SendUpdate(int tournamentId)
        {
            await Clients.All.SendAsync("matchUpdate",tournamentId);
        }
        public async Task NewTournament()
        {
            await Clients.All.SendAsync("newTournament");
        }
    }
}
