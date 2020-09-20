namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class PostViewModel
    {
        public PostViewModel(Post incomingPost)
        {
            id = incomingPost.id;
            UserId = incomingPost.UserID;
            Caption = incomingPost.Caption;
            Text = incomingPost.Text;
            Date = incomingPost.Date;

        }

       public Post()
        {
            PostCattegories = new HashSet<PostCattegory>();
            PostComments = new HashSet<PostComment>();
            PostEvents = new HashSet<PostEvent>();
            PostLiveShows = new HashSet<PostLiveShow>();
            PostPhotos = new HashSet<PostPhoto>();
            PostTutorials = new HashSet<PostTutorial>();
            PostVideos = new HashSet<PostVideo>();
            Shares = new HashSet<Share>();
            Likes = new HashSet<Like>();
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

        public virtual ICollection<PostCattegory> PostCattegories { get; set; }

        public virtual ICollection<PostComment> PostComments { get; set; }

        public virtual ICollection<PostEvent> PostEvents { get; set; }

        public virtual ICollection<PostLiveShow> PostLiveShows { get; set; }

        public virtual ICollection<PostPhoto> PostPhotos { get; set; }

         public virtual ICollection<PostTutorial> PostTutorials { get; set; }

        public virtual ICollection<PostVideo> PostVideos { get; set; }

        public virtual ICollection<Share> Shares { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
