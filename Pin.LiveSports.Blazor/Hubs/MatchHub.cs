using Microsoft.AspNetCore.SignalR;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class MatchHub : Hub
    {
        public async Task Send(string update)
        {
            await Clients.All.SendAsync("matchUpdate", update);
        }
    }
}
