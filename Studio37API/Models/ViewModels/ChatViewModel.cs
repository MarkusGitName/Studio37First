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


            List<MessageViewModel> newMessageViewModel = new List<MessageViewModel>();
            foreach (Message incomingMsge in incomingChat.Messages)
            {
                Messages.Add(new MessageViewModel(incomingMsge));
            }
            Messages = newMessageViewModel;

            List < UserChatViewModel > newUserChatViewModel = new List<UserChatViewModel>();
            foreach (UserChat userChat in incomingChat.UserChats)
            {
                newUserChatViewModel.Add(new UserChatViewModel(userChat));
            }
            UserChats = newUserChatViewModel;
        }

        public Guid ChatID { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual List<MessageViewModel> Messages { get; set; }

        public virtual List<UserChatViewModel> UserChats { get; set; }
    }
}
