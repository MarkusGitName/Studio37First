using System;
using System.Collections.Generic;
using System.Text;

namespace Studio37Media.Shared.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Event
    {
        public Event()
        {
            EventGroups = new HashSet<EventGroup>();
            EventUsers = new HashSet<EventUser>();
            PostEvents = new HashSet<PostEvent>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string EventDescription { get; set; }

        [Required]
        [StringLength(450)]
        public string EventThumbnail { get; set; }

         public virtual ICollection<EventGroup> EventGroups { get; set; }

       // public virtual Profile Profile { get; set; }

         public virtual ICollection<EventUser> EventUsers { get; set; }

        public virtual ICollection<PostEvent> PostEvents { get; set; }
    }
}
