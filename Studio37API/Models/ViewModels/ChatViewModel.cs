namespace Studio37API.Models.DataBaseMdels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chat")]
    public partial class ChatViewModel
    {
         public ChatViewModel(Chat incomingChat)
        {
            ChatID = incomingChat.ChatID;
            DateCreated = incomingChat.DateCreated;

            Messages = incomingChat.Messages;
            UserChats = incomingChat.UserChats;
        }

        public Guid ChatID { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<UserChat> UserChats { get; set; }
    }
}
