namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TutorialCommentViewModel
    {
        public TutorialCommentViewModel(TutorialComment incomingTutorialComment)
        {
            id = incomingTutorialComment.id;
            TutorialID = incomingTutorialComment.TutorialID;
            CommentID = incomingTutorialComment.CommentID;

        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid CommentID { get; set; }

        // public virtual Comment Comment { get; set; }

        // public virtual Tutorial Tutorial { get; set; }
    }
}
