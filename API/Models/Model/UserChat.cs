using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class UserChat
    {
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("ChatID")]
        public Guid? ChatId { get; set; }
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(ChatId))]
        [InverseProperty("UserChat")]
        public virtual Chat Chat { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.UserChat))]
        public virtual Profile User { get; set; }
    }
}
