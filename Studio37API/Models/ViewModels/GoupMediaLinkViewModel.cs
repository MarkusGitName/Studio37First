namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GoupMediaLinkViewModel
    {

        public GoupMediaLinkViewModel(GoupMediaLink incomingGroupMediaLink)
        {
            id = incomingGroupMediaLink.id;
            GroupID = incomingGroupMediaLink.GroupID;
            Link = incomingGroupMediaLink.Link;

        }
        public Guid id { get; set; }

        public Guid GroupID { get; set; }

        [Required]
        [StringLength(450)]
        public string Link { get; set; }

       // public virtual Group Group { get; set; }
    }
}
