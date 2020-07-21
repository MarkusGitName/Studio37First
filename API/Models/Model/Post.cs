using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Post
    {
        public Post()
        {
            PostCattegory = new HashSet<PostCattegory>();
            PostComments = new HashSet<PostComments>();
            PostLike = new HashSet<PostLike>();
            PostPhotos = new HashSet<PostPhotos>();
            PostVideo = new HashSet<PostVideo>();
            Share = new HashSet<Share>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [StringLength(450)]
        public string Caption { get; set; }
        [Column(TypeName = "text")]
        public string Text { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        [InverseProperty("PostNavigation")]
        public virtual ICollection<PostCattegory> PostCattegory { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<PostComments> PostComments { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<PostLike> PostLike { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<PostPhotos> PostPhotos { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<PostVideo> PostVideo { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<Share> Share { get; set; }
    }
}
