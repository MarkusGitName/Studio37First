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

            foreach(PostPhoto incomingPostPhotos in incomingPhoto.PostPhotos)
            {
                PostPhotos.Add(new PostPhotoViewModel(incomingPostPhotos));
            }

            foreach(Like incomingLikes in incomingPhoto.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }
     
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

        public virtual ICollection<PostPhotoViewModel> PostPhotos { get; set; }

        public virtual ICollection<LikeViewModel> Likes { get; set; }
    }
}
