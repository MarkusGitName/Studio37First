

namespace Studio37API.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

     public partial class Chat
    {
       public Chat()
        {
            Messages = new HashSet<Message>();
            UserChats = new HashSet<UserChat>();
        }

        public Guid ChatID { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual ICollection<UserChat> UserChats { get; set; }
    }
}
