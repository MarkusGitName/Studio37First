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
            foreach (ClassVideoComment incomingClassVideoComment in incomingComments.ClassVideoComments)
            {
                ClassVideoComments.Add(new ClassVideoCommentViewModel(incomingClassVideoComment));
            }
            ClassVideoComments = new CommentViewModel(incomingComments.);
            CommentComments = new HashSet<CommentComment>();
            CommentComments1 = new HashSet<CommentComment>();
            LiveShowComments = new HashSet<LiveShowComment>();
            PostComments = new HashSet<PostComment>();
            TutorialComments = new HashSet<TutorialComment>();
            Likes = new HashSet<Like>();
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
