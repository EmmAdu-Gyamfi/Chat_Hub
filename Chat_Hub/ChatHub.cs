using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat_Hub
{
   

    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

}
