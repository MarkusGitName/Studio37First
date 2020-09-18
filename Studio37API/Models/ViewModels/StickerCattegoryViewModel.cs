namespace Studio37API.Models.ViewModels
{
    using Studio37API.Models.DataBaseMdels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StickerCattegoryViewModel
    {
        public StickerCattegoryViewModel(StickerCattegory incomingStickerCattegory)
        {
            id = incomingStickerCattegory.id;
            StickeID = incomingStickerCattegory.StickeID;
            CategoryID = incomingStickerCattegory.CategoryID;
        }

        public Guid id { get; set; }

        public Guid StickeID { get; set; }

        public Guid CategoryID { get; set; }

        // public virtual Category Category { get; set; }

        // public virtual Sticker Sticker { get; set; }
    }
}
