using System;
using System.ComponentModel.DataAnnotations;

namespace Gamification.UI.Models
{
    public class UserChatInfoViewModel
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public DateTime LatestMessageTimestamp { get; set; }
        public int UnreadMessageCount { get; set; }
    }

}


