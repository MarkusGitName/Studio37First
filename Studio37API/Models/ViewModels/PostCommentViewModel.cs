namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostCommentViewModel
    {
        public PostCommentViewModel(PostComment incomingPostComment)
        {
            id = incomingPostComment.id;
            PostID = incomingPostComment.PostID;
            CommentID = incomingPostComment.CommentID;

        }

        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid CommentID { get; set; }

        // public virtual Comment Comment { get; set; }

        // public virtual Post Post { get; set; }
    }
}
