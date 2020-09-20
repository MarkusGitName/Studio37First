namespace Studio37API.Models.ViewModels
{
    
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChatViewModel
    {
         public ChatViewModel(Chat incomingChat)
        {
            ChatID = incomingChat.ChatID;
            DateCreated = incomingChat.DateCreated;

            foreach(Message incomingMsge in incomingChat.Messages)
            {
                Messages.Add(new MessageViewModels(incomingMsge));
            }
            
            foreach(UserChat userChat in incomingChat.UserChats)
            {
                UserChats.Add(new UserChatViewModel(userChat));
            }

        }

        public Guid ChatID { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<MessageViewModels> Messages { get; set; }

        public virtual ICollection<UserChatViewModel> UserChats { get; set; }
    }
}
