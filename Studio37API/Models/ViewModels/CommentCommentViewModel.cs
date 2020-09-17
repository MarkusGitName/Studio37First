namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CommentCommentViewModel
    {
        public CommentCommentViewModel(CommentComment incomingComment)
        {
            id = incomingComment.id;
            oldComment = incomingComment.oldComment;
            newComment = incomingComment.newComment;
        }
        public Guid id { get; set; }

        public Guid oldComment { get; set; }

        public Guid newComment { get; set; }

      //  public virtual Comment Comment { get; set; }

      //  public virtual Comment Comment1 { get; set; }
    }
}
