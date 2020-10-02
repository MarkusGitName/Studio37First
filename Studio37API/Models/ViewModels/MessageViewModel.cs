namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MessageViewModel
    {
        public MessageViewModel(Message incomingMessage)
        {
            MessageID = incomingMessage.MessageID;
            Msge = incomingMessage.Msge;
            Date = incomingMessage.Date;
            UserID = incomingMessage.UserID;
            ChatID = incomingMessage.ChatID;
        }

        public Guid MessageID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Msge { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public Guid ChatID { get; set; }

        // public virtual Chat Chat { get; set; }

        // public virtual Profile Profile { get; set; }
    }
}
