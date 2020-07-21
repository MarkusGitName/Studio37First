using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Comments
    {
        public Comments()
        {
            CommentCommentsNewCommentNavigation = new HashSet<CommentComments>();
            CommentCommentsOldCommentNavigation = new HashSet<CommentComments>();
            CommentLikes = new HashSet<CommentLikes>();
            PostComments = new HashSet<PostComments>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("text", TypeName = "text")]
        public string Text { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        [InverseProperty(nameof(CommentComments.NewCommentNavigation))]
        public virtual ICollection<CommentComments> CommentCommentsNewCommentNavigation { get; set; }
        [InverseProperty(nameof(CommentComments.OldCommentNavigation))]
        public virtual ICollection<CommentComments> CommentCommentsOldCommentNavigation { get; set; }
        [InverseProperty("Comment")]
        public virtual ICollection<CommentLikes> CommentLikes { get; set; }
        [InverseProperty("Comment")]
        public virtual ICollection<PostComments> PostComments { get; set; }
    }
}
