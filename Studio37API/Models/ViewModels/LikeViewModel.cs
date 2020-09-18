namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   public partial class LikeViewModel
    {
        public LikeViewModel(Like incomingLike)
        {
            id = incomingLike.id;
            UserId = incomingLike.UserId;
            date = incomingLike.date;

        }
        public Like()
        {
            Comments = new HashSet<Comment>();
            LiveShows = new HashSet<LiveShow>();
            Photos = new HashSet<Photo>();
            Posts = new HashSet<Post>();
            Profiles = new HashSet<Profile>();
            Shares = new HashSet<Share>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        public DateTime date { get; set; }

        // public virtual Profile Profile { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<LiveShow> LiveShows { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }

        public virtual ICollection<Share> Shares { get; set; }
    }
}
