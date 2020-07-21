using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Like
    {
        public Like()
        {
            CommentLikes = new HashSet<CommentLikes>();
            PhotoLike = new HashSet<PhotoLike>();
            PostLike = new HashSet<PostLike>();
            ProfileLikes = new HashSet<ProfileLikes>();
            ShareLikes = new HashSet<ShareLikes>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }

        [InverseProperty("Like")]
        public virtual ICollection<CommentLikes> CommentLikes { get; set; }
        [InverseProperty("Like")]
        public virtual ICollection<PhotoLike> PhotoLike { get; set; }
        [InverseProperty("Like")]
        public virtual ICollection<PostLike> PostLike { get; set; }
        [InverseProperty("Like")]
        public virtual ICollection<ProfileLikes> ProfileLikes { get; set; }
        [InverseProperty("Like")]
        public virtual ICollection<ShareLikes> ShareLikes { get; set; }
    }
}
