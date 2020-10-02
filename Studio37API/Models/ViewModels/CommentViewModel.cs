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
            List < ClassVideoCommentViewModel > newClassVideoCommentViewModel = new List<ClassVideoCommentViewModel>();
            foreach (ClassVideoComment incomingClassVideoComments in incomingComments.ClassVideoComments)
            {
                newClassVideoCommentViewModel.Add(new ClassVideoCommentViewModel(incomingClassVideoComments));
            }
            ClassVideoComments = newClassVideoCommentViewModel;

            List< CommentCommentViewModel > newCommentCommentViewModel = new List<CommentCommentViewModel>();
            foreach (CommentComment incomingCommentComment in incomingComments.CommentComments)
            {
                newCommentCommentViewModel.Add(new CommentCommentViewModel(incomingCommentComment));
            }
            CommentComments = newCommentCommentViewModel;

            List < CommentCommentViewModel > newCommentComment1ViewModel = new List<CommentCommentViewModel>();
            foreach (CommentComment incomingCommentComments1 in incomingComments.CommentComments1)
            {
                newCommentComment1ViewModel.Add(new CommentCommentViewModel(incomingCommentComments1));
            }
            CommentComments1 = newCommentComment1ViewModel;

            List < LiveShowCommentViewModel > newLiveShowCommentViewModel = new List<LiveShowCommentViewModel>();
            foreach (LiveShowComment incomingLiveShowComments in incomingComments.LiveShowComments)
            {
                LiveShowComments.Add(new LiveShowCommentViewModel(incomingLiveShowComments));
            }
            LiveShowComments = newLiveShowCommentViewModel;

            List < PostCommentViewModel > newPostCommentViewModel = new List<PostCommentViewModel>();
            foreach (PostComment incomingPostComments in incomingComments.PostComments)
            {
                newPostCommentViewModel.Add(new PostCommentViewModel(incomingPostComments));
            }
            PostComments = newPostCommentViewModel;

            List < TutorialCommentViewModel > newTutorialComment = new List<TutorialCommentViewModel>();
            foreach (TutorialComment incomingTutorialComments in incomingComments.TutorialComments)
            {
                newTutorialComment.Add(new TutorialCommentViewModel(incomingTutorialComments));
            }
            TutorialComments = newTutorialComment;

            List < LikeViewModel > newLikeViewModel = new List<LikeViewModel>();
            foreach (Like incomingLikes in incomingComments.Likes)
            {
                newLikeViewModel.Add(new LikeViewModel(incomingLikes));
            }
            Likes = newLikeViewModel;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string text { get; set; }

        public DateTime Date { get; set; }

        public virtual List<ClassVideoCommentViewModel> ClassVideoComments { get; set; }

        public virtual List<CommentCommentViewModel> CommentComments { get; set; }

        public virtual List<CommentCommentViewModel> CommentComments1 { get; set; }

       // public virtual Profile Profile { get; set; }

        public virtual List<LiveShowCommentViewModel> LiveShowComments { get; set; }

        public virtual List<PostCommentViewModel> PostComments { get; set; }

        public virtual List<TutorialCommentViewModel> TutorialComments { get; set; }

        public virtual List<LikeViewModel> Likes { get; set; }
    }
}
