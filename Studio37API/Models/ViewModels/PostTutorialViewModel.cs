namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class PostTutorialViewModel
    {
        public PostTutorialViewModel(PostTutorial incomingPostTutorial)
        {
            id = incomingPostTutorial.id;
            PostID = incomingPostTutorial.PostID;
            TutorialID = incomingPostTutorial.TutorialID;
        }

        public Guid id { get; set; }

        public Guid PostID { get; set; }

        public Guid TutorialID { get; set; }

        // public virtual Post Post { get; set; }

        // 
        public virtual Tutorial Tutorial { get; set; }
    }
}
