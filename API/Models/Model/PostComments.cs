using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PostComments
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("PostID")]
        public Guid? PostId { get; set; }
        [Column("CommentID")]
        public Guid? CommentId { get; set; }

        [ForeignKey(nameof(CommentId))]
        [InverseProperty(nameof(Comments.PostComments))]
        public virtual Comments Comment { get; set; }
        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostComments")]
        public virtual Post Post { get; set; }
    }
}
