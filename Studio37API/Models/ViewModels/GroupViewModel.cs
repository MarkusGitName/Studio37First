namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Text.RegularExpressions;

    public partial class GroupViewModel
    {

        public GroupViewModel(Group incomingGroup)
        {
            id = incomingGroup.id;
            OwnerID = incomingGroup.OwnerID;
            Name = incomingGroup.Name;
            Description = incomingGroup.Description;
            DateCreated = incomingGroup.DateCreated;

            EventGroups = incomingGroup.EventGroups;
            GroupMediaLinks = incomingGroup.GroupMediaLinks;
            Profiles = incomingGroup.Profiles;
       
           // EventGroups = new HashSet<EventGroup>();
           // GoupMediaLinks = new HashSet<GoupMediaLink>();
           // Profiles = new HashSet<Profile>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string OwnerID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(450)]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<EventGroup> EventGroups { get; set; }

        public virtual ICollection<GoupMediaLink> GoupMediaLinks { get; set; }

        // public virtual Profile Profile { get; set; }

       public virtual ICollection<Profile> Profiles { get; set; }
    }
}
