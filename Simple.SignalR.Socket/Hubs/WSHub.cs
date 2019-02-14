using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace Simple.SignalR.Socket.Hubs
{
    public class WSHub : Hub
    {
        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await base.OnDisconnectedAsync(ex);
            throw ex;
        }

        public async Task SendMessage(string id, string message)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(message))
                await OnDisconnectedAsync(new Exception("Invalid parameters!"));
            else
                await ReceiveMessage(id, message);
        }

        public async Task ReceiveMessage(string id, string message) => await Clients.All.SendAsync(id, message);
    }
}
