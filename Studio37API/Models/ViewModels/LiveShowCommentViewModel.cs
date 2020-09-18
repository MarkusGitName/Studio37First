namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LiveShowCommentViewModel
    {
        public LiveShowCommentViewModel (LiveShowComment incomingLiveShowComment)
        {
            id = incomingLiveShowComment.id;
            LiveShowID = incomingLiveShowComment.LiveShowID;
            CommentID = incomingLiveShowComment.CommentID;
        }

        public Guid id { get; set; }

        public Guid LiveShowID { get; set; }

        public Guid CommentID { get; set; }

       // public virtual Comment Comment { get; set; }

       // public virtual LiveShow LiveShow { get; set; }
    }
}
