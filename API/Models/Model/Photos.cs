using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class Photos
    {
        public Photos()
        {
            PhotoLike = new HashSet<PhotoLike>();
            PostPhotos = new HashSet<PostPhotos>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string Path { get; set; }

        [InverseProperty("Photo")]
        public virtual ICollection<PhotoLike> PhotoLike { get; set; }
        [InverseProperty("Photo")]
        public virtual ICollection<PostPhotos> PostPhotos { get; set; }
    }
}
