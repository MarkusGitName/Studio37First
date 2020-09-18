namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Diagnostics.Contracts;

    public partial class TutorialPromoPhotoViewModel
    {
        public TutorialPromoPhotoViewModel(TutorialPromoPhoto incomingTutorialPromoPhoto)
        {
            id = incomingTutorialPromoPhoto.id;
            TutorialID = incomingTutorialPromoPhoto.TutorialID;
            PromoPhotoID = incomingTutorialPromoPhoto.PromoPhotoID;
        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid PromoPhotoID { get; set; }

        // public virtual PromoPhoto PromoPhoto { get; set; }

        // public virtual Tutorial Tutorial { get; set; }
    }
}
