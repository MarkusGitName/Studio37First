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
        public VideoViewModel(VideoViewModel incomingVideo)
        {
            id = incomingVideo.id;
            Path = incomingVideo.Path;
        }

        public Video()
        {
            PostVideos = new HashSet<PostVideo>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string Path { get; set; }

        public virtual ICollection<PostVideo> PostVideos { get; set; }
    }
}
