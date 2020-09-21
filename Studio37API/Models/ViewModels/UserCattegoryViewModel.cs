namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserCattegoryViewModel
    {
        public UserCattegoryViewModel(UserCattegory incomingUserCattegory)
        {
            id = incomingUserCattegory.id;
            UserID = incomingUserCattegory.UserID;
            CattegorryID = incomingUserCattegory.CattegorryID;

        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public Guid CattegorryID { get; set; }

        // public virtual Category Category { get; set; }

        // public virtual Profile Profile { get; set; }
    }
}
