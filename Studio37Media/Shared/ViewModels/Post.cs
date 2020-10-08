using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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
