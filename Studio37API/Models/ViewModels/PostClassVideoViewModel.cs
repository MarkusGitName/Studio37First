namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostClassVideo")]
    public partial class PostClassVideoViewModel
    {
        public PostClassVideoViewModel(PostClassVideo incomingPostClassVideo)
        {
            id = incomingPostClassVideo.id;
            PostId = incomingPostClassVideo.PostId;
            ClassVideoId = incomingPostClassVideo.ClassVideoId;
        }
    
        public Guid id { get; set; }

        public Guid PostId { get; set; }

        public Guid ClassVideoId { get; set; }

    }
}
