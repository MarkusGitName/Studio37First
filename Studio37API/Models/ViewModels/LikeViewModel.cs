namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Threading;

    public partial class LikeViewModel
    {
        public LikeViewModel(Like incomingLike)
        {
            id = incomingLike.id;
            UserId = incomingLike.UserId;
            date = incomingLike.date;

            List<CommentViewModel> newCommentViewModel = new List<CommentViewModel>();
            foreach (Comment incomingComment in incomingLike.Comments)
            {
                Comments.Add(new CommentViewModel(incomingComment));
            }
            Comments = newCommentViewModel;

            List<LiveShowViewModel> newLiveShowViewModel = new List<LiveShowViewModel>();
            foreach (LiveShow incomingLiveShows in incomingLike.LiveShows)
            {
                LiveShows.Add(new LiveShowViewModel(incomingLiveShows));
            }
            LiveShows = newLiveShowViewModel;

            List<PhotoViewModel> newPhotoViewModel = new List<PhotoViewModel>();
            foreach (Photo incomingPhotos in incomingLike.Photos)
            {
                Photos.Add(new PhotoViewModel(incomingPhotos));
            }
            Photos = newPhotoViewModel;

            List<PostViewModel> newPostViewModel = new List<PostViewModel>();
            foreach (Post incomingPosts in incomingLike.Posts)
            {
                Posts.Add(new PostViewModel(incomingPosts));
            }
            Posts = newPostViewModel;

            List<ProfileViewModel> newProfileViewModel = new List<ProfileViewModel>();
            foreach (Profile incomingProfiles in incomingLike.Profiles)
            {
                Profiles.Add(new ProfileViewModel(incomingProfiles));
            }
            Profles = newProfileViewModel;

            List<ShareViewModel> newShareViewModel = new List<ShareViewModel>();
            foreach (Share incomingShares in incomingLike.Shares)
            {
                Shares.Add(new ShareViewModel(incomingShares));
            }
            Shares = newShareViewModel;

        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public DateTime date { get; set; }

        // public virtual Profile Profile { get; set; }

        public virtual List<CommentViewModel> Comments { get; set; }

        public virtual List<LiveShowViewModel> LiveShows { get; set; }

        public virtual List<PhotoViewModel> Photos { get; set; }

        public virtual List<PostViewModel> Posts { get; set; }

        public virtual List<ProfileViewModel> Profiles { get; set; }

        public virtual List<ShareViewModel> Shares { get; set; }
    }
}
