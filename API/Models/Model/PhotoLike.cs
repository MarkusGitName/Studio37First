using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PhotoLike
    {
        [Key]
        [Column("photoID")]
        public Guid PhotoId { get; set; }
        [Key]
        [Column("LikeID")]
        public Guid LikeId { get; set; }

        [ForeignKey(nameof(LikeId))]
        [InverseProperty("PhotoLike")]
        public virtual Like Like { get; set; }
        [ForeignKey(nameof(PhotoId))]
        [InverseProperty(nameof(Photos.PhotoLike))]
        public virtual Photos Photo { get; set; }
    }
}
