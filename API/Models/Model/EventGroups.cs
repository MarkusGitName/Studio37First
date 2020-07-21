using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class EventGroups
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("EventID")]
        public Guid? EventId { get; set; }
        [Column("GroupID")]
        public Guid? GroupId { get; set; }

        [ForeignKey(nameof(EventId))]
        [InverseProperty(nameof(Events.EventGroups))]
        public virtual Events Event { get; set; }
        [ForeignKey(nameof(GroupId))]
        [InverseProperty(nameof(Groups.EventGroups))]
        public virtual Groups Group { get; set; }
    }
}
