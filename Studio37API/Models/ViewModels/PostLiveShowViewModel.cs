namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostLiveShowViewModel
    {
        public PostLiveShowViewModel(PostLiveShow incomingPostLiveShow)
        {
            id = incomingPostLiveShow.id;
            PostID = incomingPostLiveShow.PostID;
            LiveShowID = incomingPostLiveShow.LiveShowID;
        }

        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid LiveShowID { get; set; }

        // public virtual LiveShow LiveShow { get; set; }

        // public virtual Post Post { get; set; }
    }
}
