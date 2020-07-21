namespace Studio37API.Models.DataBaseModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TutorialPromoPhoto")]
    public partial class TutorialPromoPhoto
    {
        public Guid id { get; set; }

        public Guid TutorialID { get; set; }

        public Guid PromoPhotoID { get; set; }

        public virtual PromoPhoto PromoPhoto { get; set; }

        public virtual Tutorial Tutorial { get; set; }
    }
}
