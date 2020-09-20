namespace Studio37API.Models.viewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LiveShowCattegoryViewModel
    {
        public LiveShowCattegoryViewModel(LiveShowCattegory incomingLiveShowCattegory)
        {
            id = incomingLiveShowCattegory.id;
            LiveShowID = incomingLiveShowCattegory.LiveShowID;
            CattegoryID = incomingLiveShowCattegory.CattegoryID;

        }
        public Guid id { get; set; }

        public Guid LiveShowID { get; set; }

        public Guid CattegoryID { get; set; }

        // public virtual Category Category { get; set; }

        // public virtual LiveShow LiveShow { get; set; }
    }
}
