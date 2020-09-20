namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class PostEventViewModel
    {
        public PostEventViewModel(PostEvent incomingPostEvent)
        {
            id = incomingPostEvent.id;
            PostID = incomingPostEvent.PostID;
            EventID = incomingPostEvent.EventID;
        }
        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid EventID { get; set; }

        // public virtual Event Event { get; set; }

        // public virtual Post Post { get; set; }
    }
}
