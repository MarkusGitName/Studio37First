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

            List<PostPhotoViewModel> newPostPhotoViewModel = new List<PostPhotoViewModel>();
            foreach (PostPhoto incomingPostPhotos in incomingPhoto.PostPhotos)
            {
                PostPhotos.Add(new PostPhotoViewModel(incomingPostPhotos));
            }
            PostPhotos = newPostPhotoViewModel;

            List<LikeViewModel> newLikeViewModel = new List<LikeViewModel>();
            foreach (Like incomingLikes in incomingPhoto.Likes)
            {
                Likes.Add(new LikeViewModel(incomingLikes));
            }
            Likes = newLikeViewModel;
     
        }

        public Guid id { get; set; }

        public string Caption { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

        public virtual List<PostPhotoViewModel> PostPhotos { get; set; }

        public virtual List<LikeViewModel> Likes { get; set; }
    }
}
