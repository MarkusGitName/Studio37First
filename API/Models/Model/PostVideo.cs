using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PostVideo
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("PostID")]
        public Guid? PostId { get; set; }
        [Column("VideoID")]
        public Guid? VideoId { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostVideo")]
        public virtual Post Post { get; set; }
        [ForeignKey(nameof(VideoId))]
        [InverseProperty(nameof(Videos.PostVideo))]
        public virtual Videos Video { get; set; }
    }
}
