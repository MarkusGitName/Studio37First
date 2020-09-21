namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;

    public partial class PostViewModel
    {
        public PostViewModel(Post incomingPost)
        {
            id = incomingPost.id;
            UserId = incomingPost.UserId;
            Caption = incomingPost.Caption;
            Text = incomingPost.Text;
            Date = incomingPost.Date;

            foreach(PostCattegory incomingPostCattegories in incomingPost.PostCattegories)
            {
                PostCattegories.Add(new PostCattegoryViewModel(incomingPostCattegories));
            }

            foreach(PostComment incomingPostComments in incomingPost.PostComments)
            {
                PostComments.Add(new PostCommentViewModel(incomingPostComments));
            }

            foreach(PostEvent incomingPostEvents in incomingPost.PostEvents)
            {
                PostEvents.Add(new PostEventViewModel(incomingPostEvents));
            }

            foreach(PostLiveShow incomingPostLiveShows in incomingPost.PostLiveShows)
            {
                PostLiveShows.Add(new PostLiveShowViewModel(incomingPostLiveShows));
            }

            foreach(PostPhoto incomingPostPhotos in incomingPost.PostPhotos)
            {
                PostPhotos.Add(new PostPhotoViewModel(incomingPostPhotos));
            }

            foreach(PostTutorial incomingPostTutorials in incomingPost.PostTutorials)
            {
                PostTutorials.Add(new PostTutorialViewModel(incomingPostTutorials));
            }

            foreach(PostVideo incomingPostVideos in incomingPost.PostVideos)
            {
                PostVideos.Add(new PostVideoViewModel(incomingPostVideos));
            }

            foreach(Share  incomingShares in incomingPost.Shares)
            {
                Shares.Add(new ShareViewModel(incomingShares));
            }

            foreach(Like incomingLikes in incomingPost.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }

        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Required]
        [StringLength(450)]
        public string Caption { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<PostCattegoryViewModel> PostCattegories { get; set; }

        public virtual ICollection<PostCommentViewModel> PostComments { get; set; }

        public virtual ICollection<PostEventViewModel> PostEvents { get; set; }

        public virtual ICollection<PostLiveShowViewModel> PostLiveShows { get; set; }

        public virtual ICollection<PostPhotoViewModel> PostPhotos { get; set; }

         public virtual ICollection<PostTutorialViewModel> PostTutorials { get; set; }

        public virtual ICollection<PostVideoViewModel> PostVideos { get; set; }

        public virtual ICollection<ShareViewModel> Shares { get; set; }

        public virtual ICollection<LikeViewModel> Likes { get; set; }
    }
}
