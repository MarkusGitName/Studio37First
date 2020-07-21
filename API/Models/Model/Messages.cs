using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Messages
    {
        [Key]
        [Column("MessageID")]
        public Guid MessageId { get; set; }
        [Column(TypeName = "text")]
        public string Msge { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("ChatID")]
        public Guid? ChatId { get; set; }

        [ForeignKey(nameof(ChatId))]
        [InverseProperty("Messages")]
        public virtual Chat Chat { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.Messages))]
        public virtual Profile User { get; set; }
    }
}
