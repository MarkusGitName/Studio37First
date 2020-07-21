using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Events
    {
        public Events()
        {
            EventGroups = new HashSet<EventGroups>();
            EventUsers = new HashSet<EventUsers>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("UserID")]
        [StringLength(450)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string EventName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EventDate { get; set; }
        [Column(TypeName = "text")]
        public string EventDescription { get; set; }
        [StringLength(450)]
        public string EventThumbnail { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Profile.Events))]
        public virtual Profile User { get; set; }
        [InverseProperty("Event")]
        public virtual ICollection<EventGroups> EventGroups { get; set; }
        [InverseProperty("Event")]
        public virtual ICollection<EventUsers> EventUsers { get; set; }
    }
}
