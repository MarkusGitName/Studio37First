namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime;
    using System.Text.RegularExpressions;
    using Group = DataBaseMdels.Group;

    public partial class GroupViewModel
    {

        public GroupViewModel(Group incomingGroup)
        {
            id = incomingGroup.id;
            OwnerID = incomingGroup.OwnerID;
            Name = incomingGroup.Name;
            Description = incomingGroup.Description;
            DateCreated = incomingGroup.DateCreated;

            foreach(EventGroup incomingEventGroups in incomingGroup.EventGroups)
            {
                EventGroups.Add(new EventGroupViewModel(incomingEventGroups));
            }

            foreach(GoupMediaLink incomingGroupMediaLinks in incomingGroup.GoupMediaLinks)
            {
                GroupMediaLinks.Add(new GoupMediaLinkViewModel(incomingGroupMediaLinks));
            }

            foreach(Profile incomingProfiles in incomingGroup.Profiles)
            {
                Profiles.Add(new ProfileViewModel(incomingProfiles));
            }
            
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

        public virtual ICollection<EventGroupViewModel> EventGroups { get; set; }

        public virtual ICollection<GoupMediaLinkViewModel> GroupMediaLinks { get; set; }

        // public virtual Profile Profile { get; set; }

       public virtual ICollection<ProfileViewModel> Profiles { get; set; }
    }
}
