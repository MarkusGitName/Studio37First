using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class EventUsers
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("EventID")]
        public Guid? EventId { get; set; }
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty(nameof(Events.EventUsers))]
        public virtual Events Event { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.EventUsers))]
        public virtual Profile User { get; set; }
    }
}
