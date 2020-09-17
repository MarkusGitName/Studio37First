namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventViewModel
    {
        public EventViewModel(Event incomingEvent)
        {
            id = incomingEvent.id;
            UserID = incomingEvent.UserID;
            EventName = incomingEvent.EventName;
            EventDate = incomingEvent.EventDate;
            EventDescription = incomingEvent.EventDescription;
            EventThumbnail = incomingEvent.EventThumbnail;


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
