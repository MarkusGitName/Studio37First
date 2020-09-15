using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Group
    {
        public Group()
        {
            EventGroups = new HashSet<EventGroup>();
            GoupMediaLinks = new HashSet<GoupMediaLink>();
            Profiles = new HashSet<Profile>();
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

        public virtual Profile Profile { get; set; }

        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
