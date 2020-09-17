namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventGroupViewModel
    {
        public EventGroupViewModel(EventGroup incomingEventGroup)
        {
            id = incomingEventGroup.id;
            EventID = incomingEventGroup.EventID;
            GroupID = incomingEventGroup.GroupID;
        }
        public Guid id { get; set; }

        public Guid EventID { get; set; }

        public Guid GroupID { get; set; }

       // public virtual Event Event { get; set; }

      //  public virtual Group Group { get; set; }
    }
}
