namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TutorialPromoVideoViewModel
    {
        public TutorialPromoVideoViewModel(TutorialPromoVideo incomingTutorialPromoVideo)
        {
            id = incomingTutorialPromoVideo.id;
            TutorialID = incomingTutorialPromoVideo.TutorialID;
            PromoVideoID = incomingTutorialPromoVideo.PromoVideoID;

        }

        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid PromoVideoID { get; set; }

        // public virtual PromoVideo PromoVideo { get; set; }

        // public virtual Tutorial Tutorial { get; set; }
    }
}
