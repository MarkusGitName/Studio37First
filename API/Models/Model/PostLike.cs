using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PostLike
    {
        [Key]
        public Guid PostId { get; set; }
        [Key]
        public Guid LikeId { get; set; }

        [ForeignKey(nameof(LikeId))]
        [InverseProperty("PostLike")]
        public virtual Like Like { get; set; }
        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostLike")]
        public virtual Post Post { get; set; }
    }
}
