using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class CommentLikes
    {
        [Key]
        [Column("CommentID")]
        public Guid CommentId { get; set; }
        [Key]
        [Column("LikeID")]
        public Guid LikeId { get; set; }

        [ForeignKey(nameof(CommentId))]
        [InverseProperty(nameof(Comments.CommentLikes))]
        public virtual Comments Comment { get; set; }
        [ForeignKey(nameof(LikeId))]
        [InverseProperty("CommentLikes")]
        public virtual Like Like { get; set; }
    }
}
