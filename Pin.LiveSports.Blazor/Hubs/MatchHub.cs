using Microsoft.AspNetCore.SignalR;
using Pin.LiveSports.Blazor.Models;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class MatchHub : Hub
    {
        public async Task SendUpdate(MatchUpdate update)
        {
            await Clients.All.SendAsync("matchUpdate", update);
        }
    }
}
