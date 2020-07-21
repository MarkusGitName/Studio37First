using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class ShareLikes
    {
        [Key]
        [Column("ShareID")]
        public Guid ShareId { get; set; }
        [Key]
        [Column("LikeID")]
        public Guid LikeId { get; set; }

        [ForeignKey(nameof(LikeId))]
        [InverseProperty("ShareLikes")]
        public virtual Like Like { get; set; }
        [ForeignKey(nameof(ShareId))]
        [InverseProperty("ShareLikes")]
        public virtual Share Share { get; set; }
    }
}
