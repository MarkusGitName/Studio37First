namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserChatViewModel
    {
        public UserChatViewModel(UserChat incomingUserChat)
        {
            id = incomingUserChat.id;
            UserID = incomingUserChat.UserID;
            ChatID = incomingUserChat.ChatID;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public Guid ChatID { get; set; }

        // public virtual Chat Chat { get; set; }

        // public virtual Profile Profile { get; set; }
    }
}
