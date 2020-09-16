namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClassVideoCommentViewModel
    {
        public ClassVideoCommentViewModel(ClassVideoComment incomingClassVideoComment)
        {
            id = incomingClassVideoComment.id;
            ClassVideoID = incomingClassVideoComment.ClassVideoID;
            CommentID = incomingClassVideoComment.CommentID;
        }

        public Guid id { get; set; }

        public Guid ClassVideoID { get; set; }

        public Guid CommentID { get; set; }

        //public virtual ClassVideo ClassVideo { get; set; }

       // public virtual Comment Comment { get; set; }
    }
}
