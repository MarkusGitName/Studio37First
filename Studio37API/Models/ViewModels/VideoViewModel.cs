namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VideoViewModel
    {
        public VideoViewModel(Video incomingVideo)
        {
            id = incomingVideo.id;
            Path = incomingVideo.Path;

            List<PostVideoViewModel> newPostVideoViewModel = new List<PostVideoViewModel>();
            foreach (PostVideo incomingPostVideos in incomingVideo.PostVideos)
            {
                PostVideos.Add(new PostVideoViewModel(incomingPostVideos));
            }
            PostVideos = newPostVideoViewModel;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

        public virtual List<PostVideoViewModel> PostVideos { get; set; }
    }
}
