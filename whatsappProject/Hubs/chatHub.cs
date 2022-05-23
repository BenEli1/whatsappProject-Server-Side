﻿using Microsoft.AspNetCore.SignalR;
using whatsappProject.Controllers;
using whatsappProject.Models;

namespace whatsappProject.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string contactName, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, contactName, message);
        }
    }
}