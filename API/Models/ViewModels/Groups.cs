using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Groups
    {
        public Groups()
        {
            EventGroups = new HashSet<EventGroups>();
            GoupMediaLink = new HashSet<GoupMediaLink>();
            GroupUser = new HashSet<GroupUser>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("OwnerID")]
        [StringLength(450)]
        public string OwnerId { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(450)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }

        [ForeignKey(nameof(OwnerId))]
        [InverseProperty(nameof(Profile.Groups))]
        public virtual Profile Owner { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<EventGroups> EventGroups { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<GoupMediaLink> GoupMediaLink { get; set; }
        [InverseProperty("Group")]
        public virtual ICollection<GroupUser> GroupUser { get; set; }
    }
}
