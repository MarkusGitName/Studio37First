using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Chat
    {
        public Chat()
        {
            Messages = new HashSet<Messages>();
            UserChat = new HashSet<UserChat>();
        }

        [Key]
        [Column("ChatID")]
        public Guid ChatId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }

        [InverseProperty("Chat")]
        public virtual ICollection<Messages> Messages { get; set; }
        [InverseProperty("Chat")]
        public virtual ICollection<UserChat> UserChat { get; set; }
    }
}
