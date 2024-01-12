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

        public async Task SendUpdate(MatchUpdate update)
        {
            _matchService.AddUpdateToHistory(update);
            await Clients.All.SendAsync("matchUpdate",update);
        }
        public async Task NewTournament()
        {
            await Clients.All.SendAsync("newTournament");
        }
    }
}
