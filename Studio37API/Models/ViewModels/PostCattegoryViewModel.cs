namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class PostCattegoryViewModel
    {
        public PostCattegoryViewModel(PostCattegory incomingPostCattegory)
        {
            id = incomingPostCattegory.id;
            PostID = incomingPostCattegory.PostID;
            CategoryID = incomingPostCattegory.CategoryID;

        }

        public Guid id { get; set; }

        public Guid PostID { get; set; }

        [Required]
        [StringLength(125)]
        public string CategoryID { get; set; }

        // public virtual Category Category { get; set; }

        // public virtual Post Post { get; set; }
    }
}
