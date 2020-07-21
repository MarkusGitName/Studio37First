using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class GoupMediaLink
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("GroupID")]
        public Guid GroupId { get; set; }
        [Required]
        [StringLength(450)]
        public string Link { get; set; }

        [ForeignKey(nameof(GroupId))]
        [InverseProperty(nameof(Groups.GoupMediaLink))]
        public virtual Groups Group { get; set; }
    }
}
