using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public partial class PromoPhotos
    {
        public PromoPhotos()
        {
            TutorialPromoPhoto = new HashSet<TutorialPromoPhoto>();
        }

        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        [StringLength(450)]
        public string PhotoPath { get; set; }

        [InverseProperty("PromoPhoto")]
        public virtual ICollection<TutorialPromoPhoto> TutorialPromoPhoto { get; set; }
    }
}
