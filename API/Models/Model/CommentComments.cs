using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class CommentComments
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("oldComment")]
        public Guid? OldComment { get; set; }
        [Column("newComment")]
        public Guid? NewComment { get; set; }

        [ForeignKey(nameof(NewComment))]
        [InverseProperty(nameof(Comments.CommentCommentsNewCommentNavigation))]
        public virtual Comments NewCommentNavigation { get; set; }
        [ForeignKey(nameof(OldComment))]
        [InverseProperty(nameof(Comments.CommentCommentsOldCommentNavigation))]
        public virtual Comments OldCommentNavigation { get; set; }
    }
}
