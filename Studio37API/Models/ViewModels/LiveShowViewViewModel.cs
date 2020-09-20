namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class LiveShowViewViewModel
    {
        public LiveShowViewViewModel(LiveShowView incomingLiveShowView)
        {
            id = incomingLiveShowView.id;
            LiveShowID = incomingLiveShowView.LiveShowID;
            UserID = incomingLiveShowView.UserID;
            JoinTime = incomingLiveShowView.JoinTime;
            LeaveLtime = incomingLiveShowView.LeaveLtime;
        }

        public Guid id { get; set; }

        public Guid LiveShowID { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public DateTime JoinTime { get; set; }

        public DateTime LeaveLtime { get; set; }

        // public virtual LiveShow LiveShow { get; set; }

        // public virtual Profile Profile { get; set; }
    }
}
