namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PromoVideoViewModel
    {
        public PromoVideoViewModel(PromoVideo incomingPromoVideo)
        {
            id = incomingPromoVideo.id;
            VideoPath = incomingPromoVideo.VideoPath;

            foreach(TutorialPromoVideo incomingTutorialPromoVideos in incomingPromoVideo.TutorialPromoVideos)
            {
                TutorialPromoVideos.Add(new TutorialPromoVideoViewModel(incomingTutorialPromoVideos));
            }

        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string VideoPath { get; set; }

        public virtual List<TutorialPromoVideoViewModel> TutorialPromoVideos { get; set; }
    }
}
