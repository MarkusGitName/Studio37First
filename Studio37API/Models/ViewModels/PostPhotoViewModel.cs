namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PostPhotoViewModel
    {
        public PostPhotoViewModel(PostPhoto incomingPostPhoto)
        {
            id = incomingPostPhoto.id;
            PostID = incomingPostPhoto.PostID;
            PhotoID = incomingPostPhoto.PhotoID;
        }

        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid PhotoID { get; set; }


        // public virtual Photo Photo { get; set; }

        // public virtual Post Post { get; set; }
    }
}
