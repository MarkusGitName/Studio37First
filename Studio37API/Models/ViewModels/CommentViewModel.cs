namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CommentViewModel
    {
         public CommentViewModel(Comment incomingComments)
        {
            foreach (ClassVideoComment incomingClassVideoComments in incomingComments.ClassVideoComments)
            {
                ClassVideoComments.Add(new ClassVideoCommentViewModel(incomingClassVideoComments));
            }
            foreach (CommentComment incomingCommentComment in incomingComments.CommentComments)
            {
                CommentComments.Add(new CommentCommentViewModel(incomingCommentComment));
            }

            foreach (CommentComment incomingCommentComments1 in incomingComments.CommentComments1)
            {
                CommentComments1.Add(new CommentComments1ViewlModel(incomingCommentComments1));
            }

            foreach(LiveShowComment incomingLiveShowComments in incomingComments.LiveShowComments)
            {
                LiveShowComments.Add(new LiveShowCommentViewModel(incomingLiveShowComments));
            }

            foreach(PostComment incomingPostComments in incomingComments.PostComments)
            {
                PostComments.Add(new PostCommentViewModel(incomingPostComments));
            }

            foreach(TutorialComment incomingTutorialComments in incomingComments.TutorialComments)
            {
                TutorialComments.Add(new TutorialCommentViewModel(incomingTutorialComments));
            }

            foreach(Like incomingLikes in incomingComments.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }
            
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string text { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<ClassVideoCommentViewModel> ClassVideoComments { get; set; }

        public virtual ICollection<CommentCommentViewModel> CommentComments { get; set; }

        public virtual ICollection<CommentCommentViewModel> CommentComments1 { get; set; }

       // public virtual Profile Profile { get; set; }

        public virtual ICollection<LiveShowCommentViewModel> LiveShowComments { get; set; }

        public virtual ICollection<PostCommentViewModel> PostComments { get; set; }

        public virtual ICollection<TutorialCommentViewModel> TutorialComments { get; set; }

        public virtual ICollection<LikeViewModel> Likes { get; set; }
    }
}
