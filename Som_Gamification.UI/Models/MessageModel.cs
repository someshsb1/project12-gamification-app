using System;
using System.ComponentModel.DataAnnotations;

namespace Gamification.UI.Models
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime Timestamp { get; set; }

        [Required]
        public string SenderID { get; set; }

        [Required]
        public string ReceiverID { get; set; }

        // New field to track if the message is read
        public bool IsRead { get; set; }

        // Navigation properties to establish relationships with users
        public ApplicationUser Sender { get; set; }
        public ApplicationUser Receiver { get; set; }
    }
}
