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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventGroup> EventGroups { get; set; }

        public virtual Profile Profile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventUser> EventUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostEvent> PostEvents { get; set; }
    }
}
