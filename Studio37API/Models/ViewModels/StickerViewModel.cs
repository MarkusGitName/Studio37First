namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StickerViewModel
    {
        public StickerViewModel(Sticker incomingSticker)
        {
            id = incomingSticker.id;
            UserID = incomingSticker.UserID;
            Grade = incomingSticker.Grade;

            List<StickerCattegoryViewModel> newStickerCategoryViewModel = new List<StickerCattegoryViewModel>(); 
            foreach (StickerCattegory incomingStickerCattegories in incomingSticker.StickerCattegories)
            {
                StickerCattegories.Add(new StickerCattegoryViewModel(incomingStickerCattegories));
            }
            StickerCattegories = newStickerCategoryViewModel;
        }

        public Guid id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserID { get; set; }

        public int Grade { get; set; }

        // public virtual ProfesionallsProfile ProfesionallsProfile { get; set; }

        public virtual List<StickerCattegoryViewModel> StickerCattegories { get; set; }
    }
}
