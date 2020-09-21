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

            foreach(Comment incomingComment in incomingLike.Comments)
            {
                Comments.Add(new CommentViewModel(incomingComment));
            }

            foreach(LiveShow incomingLiveShows in incomingLike.LiveShows)
            {
                LiveShows.Add(new LiveShowViewModel(incomingLiveShows));
            }

            foreach(Photo incomingPhotos in incomingLike.Photos)
            {
                Photos.Add(new PhotoViewModel(incomingPhotos));
            }

            foreach(Post incomingPosts in incomingLike.Posts)
            {
                Posts.Add(new PostViewModel(incomingPosts));
            }

            foreach(Profile incomingProfiles in incomingLike.Profiles)
            {
                Profiles.Add(new ProfileViewModel(incomingProfiles));
            }

            foreach(Share incomingShares in incomingLike.Shares)
            {
                Shares.Add(new ShareViewModel(incomingShares));
            }

        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public DateTime date { get; set; }

        // public virtual Profile Profile { get; set; }

        public virtual ICollection<CommentViewModel> Comments { get; set; }

        public virtual ICollection<LiveShowViewModel> LiveShows { get; set; }

        public virtual ICollection<PhotoViewModel> Photos { get; set; }

        public virtual ICollection<PostViewModel> Posts { get; set; }

        public virtual ICollection<ProfileViewModel> Profiles { get; set; }

        public virtual ICollection<ShareViewModel> Shares { get; set; }
    }
}
