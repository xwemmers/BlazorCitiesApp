using Microsoft.AspNetCore.SignalR;

namespace BlazorCitiesApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public void SendChat(string username, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", username, message);            
        }

        public void Logout(string username)
        {
            Clients.Others.SendAsync("UserLoggedout", username);
        }

        public async override Task OnDisconnectedAsync(Exception? exception)
        {
            Console.WriteLine("Disconnected: " + Context.ConnectionId);
            await Clients.Others.SendAsync("UserLoggedout", Context.ConnectionId);

        }

    }
}
