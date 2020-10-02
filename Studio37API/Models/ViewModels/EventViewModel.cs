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


            List<EventGroupViewModel> newEventGroupViewModelViewModel = new List<EventGroupViewModel>();
            foreach (EventGroup incomingEventGroupViewModel in incomingEvent.EventGroups)
            {
                newEventGroupViewModelViewModel.Add(new EventGroupViewModel(incomingEventGroupViewModel));
            }
            EventGroups = newEventGroupViewModelViewModel;    
            
            List<EventUserViewModel> newEventUserViewModel = new List<EventUserViewModel>();
            foreach (EventUser incomingEventUser in incomingEvent.EventUsers)
            {
                newEventUserViewModel.Add(new EventUserViewModel(incomingEventUser));
            }
            EventUsers = newEventUserViewModel;
            
            List<PostEventViewModel> newPostEventViewModel = new List<PostEventViewModel>();
            foreach (PostEvent incomingPostEventViewModel in incomingEvent.PostEvents)
            {
                newPostEventViewModel.Add(new PostEventViewModel(incomingPostEventViewModel));
            }

            PostEvents = newPostEventViewModel;

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

        public virtual List<EventGroupViewModel> EventGroups { get; set; }

       // public virtual Profile Profile { get; set; }

        public virtual List<EventUserViewModel> EventUsers { get; set; }

        public virtual List<PostEventViewModel> PostEvents { get; set; }
    }
}
