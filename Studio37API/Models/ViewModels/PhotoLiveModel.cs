namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PhotoViewModel
    {
        public PhotoViewModel(Photo incomingPhoto)
        {
            id = incomingPhoto.id;
            Path = incomingPhoto.Path;
     
            PostPhotos = new HashSet<PostPhoto>();
            Likes = new HashSet<Like>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

        public virtual ICollection<PostPhoto> PostPhotos { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
