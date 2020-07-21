using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PostPhotos
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("PostID")]
        public Guid? PostId { get; set; }
        [Column("PhotoID")]
        public Guid? PhotoId { get; set; }

        [ForeignKey(nameof(PhotoId))]
        [InverseProperty(nameof(Photos.PostPhotos))]
        public virtual Photos Photo { get; set; }
        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostPhotos")]
        public virtual Post Post { get; set; }
    }
}
