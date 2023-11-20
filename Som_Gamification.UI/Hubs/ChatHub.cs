using Gamification.UI.Data;
using Gamification.UI.Models;
using Gamification.UI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Gamification.UI.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace Gamification.UI.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _db;

        public ChatHub(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task SendMessage(string userId, Message message)
        {
            // Send the message to the specified user
            await Clients.User(userId).SendAsync("ReceiveMessage", message);
        }

        public async Task MarkMessageAsRead(int messageId)
        {
            var message = _db.Messages.FirstOrDefault(m => m.MessageID == messageId);

            if (message != null)
            {
                // Mark the message as read in your database
                message.IsRead = true;
                await _db.SaveChangesAsync();

            }
        }
    }
}