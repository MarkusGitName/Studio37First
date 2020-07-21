using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class TutorialPromoPhoto
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("TutorialID")]
        public Guid? TutorialId { get; set; }
        [Column("PromoPhotoID")]
        public Guid? PromoPhotoId { get; set; }

        [ForeignKey(nameof(PromoPhotoId))]
        [InverseProperty(nameof(PromoPhotos.TutorialPromoPhoto))]
        public virtual PromoPhotos PromoPhoto { get; set; }
        [ForeignKey(nameof(TutorialId))]
        [InverseProperty("TutorialPromoPhoto")]
        public virtual Tutorial Tutorial { get; set; }
    }
}
