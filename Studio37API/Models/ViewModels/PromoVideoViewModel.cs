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
            VideoPath = incomingPromoVideo.id;
        }

       public PromoVideo()
        {
            TutorialPromoVideos = new HashSet<TutorialPromoVideo>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string VideoPath { get; set; }

        public virtual ICollection<TutorialPromoVideo> TutorialPromoVideos { get; set; }
    }
}
