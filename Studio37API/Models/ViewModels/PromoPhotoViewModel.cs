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
      
            TutorialPromoPhotoes = new HashSet<TutorialPromoPhoto>();
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string PhotoPath { get; set; }

        public virtual ICollection<TutorialPromoPhoto> TutorialPromoPhotoes { get; set; }
    }
}
