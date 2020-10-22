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

            List<PostCattegoryViewModel> newPostCattegoryViewModelList = new List<PostCattegoryViewModel>();
            foreach (PostCattegory incomingPostCattegories in incomingPost.PostCattegories)
            {
                newPostCattegoryViewModelList.Add(new PostCattegoryViewModel(incomingPostCattegories));
            }
            PostCattegories = newPostCattegoryViewModelList;

            List<PostCommentViewModel> newPostCommentViewModelList = new List<PostCommentViewModel>();
            foreach (PostComment incomingPostComments in incomingPost.PostComments)
            {
                newPostCommentViewModelList.Add(new PostCommentViewModel(incomingPostComments));
            }
            PostComments = newPostCommentViewModelList;


            List<PostEventViewModel> newPostEventViewModelList = new List<PostEventViewModel>();
            foreach (PostEvent incomingPostEvents in incomingPost.PostEvents)
            {
                newPostEventViewModelList.Add(new PostEventViewModel(incomingPostEvents));
            }
            PostEvents = newPostEventViewModelList;


            List<PostLiveShowViewModel> newPostLiveShowList = new List<PostLiveShowViewModel>();
            foreach (PostLiveShow incomingPostLiveShows in incomingPost.PostLiveShows)
            {
                newPostLiveShowList.Add(new PostLiveShowViewModel(incomingPostLiveShows));
            }PostLiveShows = newPostLiveShowList;



            List<PostPhotoViewModel> newPostPhotoViewModelList = new List<PostPhotoViewModel>();
            foreach (PostPhoto incomingPostPhotos in incomingPost.PostPhotos)
            {
                newPostPhotoViewModelList.Add(new PostPhotoViewModel(incomingPostPhotos));
            }
            PostPhotos = newPostPhotoViewModelList;

            List<PostTutorialViewModel> newPostTutorialViewModelList = new List<PostTutorialViewModel>();
            foreach (PostTutorial incomingPostTutorials in incomingPost.PostTutorials)
            {
                newPostTutorialViewModelList.Add(new PostTutorialViewModel(incomingPostTutorials));
            }
            PostTutorials = newPostTutorialViewModelList;

            List<PostVideoViewModel> newPostVideoViewModelList = new List<PostVideoViewModel>();
            foreach (PostVideo incomingPostVideos in incomingPost.PostVideos)
            {
                newPostVideoViewModelList.Add(new PostVideoViewModel(incomingPostVideos));
            }
            PostVideos = newPostVideoViewModelList;


            List<ShareViewModel> newShareViewModelList = new List<ShareViewModel>();
            foreach (Share  incomingShares in incomingPost.Shares)
            {
                newShareViewModelList.Add(new ShareViewModel(incomingShares));
            }
            Shares = newShareViewModelList;


            List<LikeViewModel> newLikeViewModellList = new List<LikeViewModel>();
            foreach (Like incomingLikes in incomingPost.Likes)
            {
                newLikeViewModellList.Add(new LikeViewModel(incomingLikes));
            }
            Likes = newLikeViewModellList;
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

        public virtual List<PostCattegoryViewModel> PostCattegories { get; set; }

        public virtual List<PostCommentViewModel> PostComments { get; set; }

        public virtual List<PostEventViewModel> PostEvents { get; set; }

        public virtual List<PostLiveShowViewModel> PostLiveShows { get; set; }

        public virtual List<PostPhotoViewModel> PostPhotos { get; set; }

         public virtual List<PostTutorialViewModel> PostTutorials { get; set; }

        public virtual List<PostVideoViewModel> PostVideos { get; set; }

        public virtual List<ShareViewModel> Shares { get; set; }

        public virtual List<LikeViewModel> Likes { get; set; }
    }
}
