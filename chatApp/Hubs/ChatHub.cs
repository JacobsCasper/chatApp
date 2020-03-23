using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace chatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("recieveMessage", message);
    }
}
