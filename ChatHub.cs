using Microsoft.AspNetCore.SignalR;

namespace ClientResultSample
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return Clients.All.SendAsync("Connect", $"Connection '{Context.ConnectionId}' is connected.");
        }

        public async Task<string> GetMessage(string ID)
        {
            var res = await Clients.Single(ID).InvokeAsync<string>("GetMessage");
            return $"From {ID}: {res}";
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return Clients.All.SendAsync("Connect", $"Connection '{Context.ConnectionId}' is disconnected.");
        }
    }
}
