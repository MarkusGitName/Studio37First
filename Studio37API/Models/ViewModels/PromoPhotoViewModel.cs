namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PromoPhotoViewModel
    {
        public PromoPhotoViewModel(PromoPhoto incomingPromoPhoto)
        {
            id = incomingPromoPhoto.id;

            List<TutorialPromoPhotoViewModel> newTutorialPromoPhotoViewModel = new List<TutorialPromoPhotoViewModel>();
            foreach (TutorialPromoPhoto incomingTutorialPromoPhotoes in incomingPromoPhoto.TutorialPromoPhotoes)
            {
                TutorialPromoPhotoes.Add(new TutorialPromoPhotoViewModel(incomingTutorialPromoPhotoes));
            }
            TutorialPromoPhotoes = newTutorialPromoPhotoViewModel;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string PhotoPath { get; set; }

        public virtual List<TutorialPromoPhotoViewModel> TutorialPromoPhotoes { get; set; }
    }
}
