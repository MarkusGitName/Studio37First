namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class PostVideoViewModel
    {
        public PostVideoViewModel(PostVideo incomingPostVideo)
        {
            id = incomingPostVideo.id;
            PostID = incomingPostVideo.PostID;
            VideoID = incomingPostVideo.VideoID;

        }

        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid VideoID { get; set; }


        // public virtual Post Post { get; set; }

        // public virtual Video Video { get; set; }
    }
}
